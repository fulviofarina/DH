// Accord.NET Sample Applications
// http://accord-framework.net
//
// Copyright © Rémy Dispagne, 2013
// cramer at libertysurf.fr
//
// Copyright © 2009-2014, César Souza
// All rights reserved. 3-BSD License:
//
//   Redistribution and use in source and binary forms, with or without
//   modification, are permitted provided that the following conditions are met:
//
//      * Redistributions of source code must retain the above copyright
//        notice, this list of conditions and the following disclaimer.
//
//      * Redistributions in binary form must reproduce the above copyright
//        notice, this list of conditions and the following disclaimer in the
//        documentation and/or other materials provided with the distribution.
//
//      * Neither the name of the Accord.NET Framework authors nor the
//        names of its contributors may be used to endorse or promote products
//        derived from this software without specific prior written permission.
//
//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
//  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
//  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
//  DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
//  DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
//  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
//  LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
//  ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
//  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Accord.Math.Kinematics;

namespace DH
{
    /// <summary>
    ///   Denavit-Hartenberg models for kinematic chains.
    /// </summary>
    ///
    /// <remarks>
    ///   This sample application, together with the original Denavit-Hartenberg model
    ///   classes, were contributed to the framework by Rémy Dispagne. The framework
    ///   author is immensely grateful to Rémy for this outstanding contribution!
    /// </remarks>
    ///
    public partial class DHForm : Form
    {
        private DenavitHartenbergModel model_tgripper;  // The model left gripper
        private DenavitHartenbergModel model_bgripper;  // The model right gripper

        private DH.db.ModelsRow currentModel = null;
        private DH.db.ModelsRow basePosition = null;
        private DH.db.JointsRow currentJoint = null;

        private int maxPathCnt = 10;

        private ucView ucView = null;
        private DenavitHartenbergNode[] nodes = null;

        public DHForm()
        {
            InitializeComponent();
        }


        #region calledOnce Initializers
        private void MainForm_Load(object sender, EventArgs e)
        {
            ucView = new ucView();
            ucView.Dock = DockStyle.Fill;
            sC.Panel2.Controls.Add(ucView);

            fillData(sender, e);

            getCurrentItems(sender, e);

            setDGVItems(sender, e);
            //  setBindingSources(sender,e);

            refreshBtn_Click(sender, e);

            timer1.Interval = Convert.ToInt32(timeBox.Text);

            // timer1.Enabled = true;
        }


        /// <summary>
        /// Makes the first rows that the Database must have to start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getCurrentItems(object sender, EventArgs e)
        {
            //find currentModel
            if (this.db.Models.Count == 0)
            {
                currentModel = this.db.Models.MakeAModel(1);
                this.saveItems(sender, e);
            }
          //  else currentModel = this.db.Models.FirstOrDefault();

                       
            //find current EndPointPosition
            basePosition = this.db.Models.FirstOrDefault(o => o.ModelType == -1);
            if (basePosition == null)
            {
                basePosition = this.db.Models.MakeAModel(-1);
                this.saveItems(sender, e);
            }

        
        }

        /// <summary>
        /// Clicks on the DGV to bring in the CurrenRows to employ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setDGVItems(object sender, EventArgs e)
        {
            //object sender;
            MouseEventArgs mouse = new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0);
            DataGridViewCellMouseEventArgs k = new DataGridViewCellMouseEventArgs(-1, 0, 0, 0, mouse);
            sender = this.modelsDataGridView;
            this.dgv_RowHeaderMouseClick(sender, k);
            sender = this.jointsDataGridView;
            this.dgv_RowHeaderMouseClick(sender, k);
         //   return sender;
        }


        /// <summary>
        /// Fill the tables with data from the SQL database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fillData(object sender, EventArgs e)
        {
            // Start the animation
          
            // TODO: This line of code loads data into the 'db.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.db.Models);
            // TODO: This line of code loads data into the 'db.Joints' table. You can move, or remove it, as needed.
            this.freedomTableAdapter.Fill(this.db.Freedom);
            this.jointsTableAdapter.Fill(this.db.Joints);
            this.factorsTableAdapter.Fill(this.db.Factors);
        }

        #endregion



        /// <summary>
        /// Establishes all the binginds Sources links
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setBindingSources(object sender, EventArgs e)
        {
            int colId = 0;
            string colFilter = this.db.Models.ModelTypeColumn.ColumnName;
            this.modelsBindingSource.Filter = colFilter + " > " + 0;
            this.pointEndBS.Filter = colFilter + " < " + 0;
            this.lastPointBS.Filter = colFilter + " = " + 0;
            //    this.lastPointBS.Filter += " And COUNT(1)";
            this.lastPointBS.Sort = this.db.Models.IDColumn.ColumnName + " asc";

            if (currentModel != null)
            {
                colFilter = this.db.Joints.ModelIDColumn.ColumnName;
                colId = currentModel.ID;
                this.jointsBindingSource.Filter = colFilter + " = " + colId;
                this.jointsBindingSource.Sort = this.db.Joints.NrColumn.ColumnName + " asc";
            }
            if (currentJoint != null)
            {
                colFilter = this.db.Freedom.JointIDColumn.ColumnName;
                colId = currentJoint.ID;
                this.freedomBindingSource.Filter = colFilter + " = " + colId;

                colFilter = this.db.Factors.JointIDColumn.ColumnName;
                //  colId = currentJoint.ID;
                this.factorsBS.Filter = colFilter + " = " + colId;
            }
        }

        #region buttons Model/Animate


        // Pause/Start button
        /// <summary>
        /// Button to Animate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Toggle animation
            saveItems(sender, e);
            timer1.Enabled = !timer1.Enabled;
        }


        /// <summary>
        /// Timer that performs the actual animation when Enambled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Let's move some joints to make a "hello" or "help meeee !" gesture !
            timer1.Enabled = false;
            timer1.Interval = Convert.ToInt32(timeBox.Text);

            this.db.AnimateAs();

            refreshBtn_Click(sender, e);

            this.db.SetFKTFromBaseToEndPoint(nodes);

            this.db.FindEndPosition(basePosition.Vector);

            try
            {
                maxPathCnt = Convert.ToInt32(this.PathCntBox.Text);
            }
            catch (Exception)

            {
            }

            bool toSaveCheckPoint = this.db.ShouldCheck(maxPathCnt);

            if (toSaveCheckPoint)
            {
                IEnumerable<object> images = ucView.SavePics();
                this.db.CheckIteration(ref images);
                images = null;

                this.db.CleanPath();
                saveItems(sender, e);
                this.db.Images.Clear();
            }

            timer1.Enabled = true;
        }

        /// <summary>
        /// not used yet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gripperBtn_Click(object sender, EventArgs e)
        {
            // Create the top finger
            model_tgripper = new DenavitHartenbergModel();

            model_tgripper.Joints.Add(alpha: 0, theta: Math.PI / 4, radius: 20, offset: 0);
            model_tgripper.Joints.Add(alpha: 0, theta: -Math.PI / 3, radius: 20, offset: 0);

            // Create the bottom finger
            model_bgripper = new DenavitHartenbergModel();
            model_bgripper.Joints.Add(alpha: 0, theta: -Math.PI / 4, radius: 20, offset: 0);
            model_bgripper.Joints.Add(alpha: 0, theta: Math.PI / 3, radius: 20, offset: 0);

            // Add the top finger
            currentModel.Arm.Children.Add(model_tgripper);

            // Add the bottom finger
            currentModel.Arm.Children.Add(model_bgripper);

            refreshBtn_Click(sender, e);
        }


        /// <summary>
        /// Adds a model or a joint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
         //   bool makeModel = sender == modelBtn;
            if (sender == modelBtn)
            {
               currentModel = this.db.Models.MakeAModel(1);
             
            }
            else if (sender == jointBtn)
            {
                currentJoint = this.db.Joints.MakeAJoint(ref currentModel);
                this.saveItems(sender, e);
                this.db.Freedom.MakeAFreedom(currentJoint.ID);
                this.db.Factors.MakeAFactor(currentJoint.ID);
               
            }


            this.saveItems(sender, e);

            refreshBtn_Click(sender, e);
        }

        #endregion buttons Model/Animate

        #region buttons database

        /// <summary>
        /// Animates the pictures stored in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cineBtn_Click(object sender, EventArgs e)
        {
            this.imagesTA.Fill(this.db.Images);

            //GET AN AARAY OF IMAGES
            // images = new List<System.Drawing.Image>();

            IEnumerable<object> images = this.db.GetImages();
            //DISPLAY MOVIES
            ucView.DisplayCinema(ref images);
        }


        /// <summary>
        /// cleans the end-point points
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clean_Click(object sender, EventArgs e)
        {
            this.db.CleanPath();

            saveItems(sender, e);

            refreshBtn_Click(sender, e);
        }


        /// <summary>
        /// refreshes the nodes and images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            //create models based on the tables
            this.db.Link();

            //compute all nodes
            nodes = this.db.ComputeNodes();
            
            //draw
            ucView.Draw(nodes);




         
        }


        /// <summary>
        /// saves data into the SQL database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveItems(object sender, EventArgs e)
        {
            this.Validate();

            IEnumerable<object> bss = this.Controls.OfType<BindingSource>();
            foreach (BindingSource bs in bss)
            {
                bs.EndEdit();
            }
            this.tableAdapterManager.UpdateAll(this.db);
        }

        #endregion buttons database

        #region DGV

        /// <summary>
        /// Stop the animation when editing the cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (timer1.Enabled) timer1.Enabled = false;
            //  timer1.Enabled = !timer1.Enabled;
        }

        /// <summary>
        /// DGV seleccion of currentRows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            DataGridViewRow dgvr = dgv.Rows[e.RowIndex];

            if (dgvr == null) return;

            DataRowView v = dgvr.DataBoundItem as DataRowView;

            if (dgv.Equals(this.modelsDataGridView)) currentModel = v.Row as db.ModelsRow;
            else if (dgv.Equals(this.jointsDataGridView)) currentJoint = v.Row as db.JointsRow;

            //link binding sources of FORM
            setBindingSources(sender, e);

            refreshBtn_Click(sender, e);
        }


        /// <summary>
        /// Resume the animation when finished editing the cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!timer1.Enabled) timer1.Enabled = true;
        }

        #endregion DGV
    }
}