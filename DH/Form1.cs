﻿// Accord.NET Sample Applications
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
using System.Windows.Forms;
using Accord.Controls;
using Accord.Math.Kinematics;
using Accord.Math;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    public partial class Form1 : Form
    {
    
        DenavitHartenbergModel model_tgripper;  // The model left gripper
        DenavitHartenbergModel model_bgripper;  // The model right gripper

        // The whole arm made of a combination of 
        // the three previously declared models:
        //
     //   IList<DenavitHartenbergModel> models;           // The arm base model
     //   IList<DenavitHartenbergNode> arms;

 
        double angle = 0;                // Angle variable for animation

        ucView ucView=null;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.db.Models);
            // TODO: This line of code loads data into the 'db.Joints' table. You can move, or remove it, as needed.
            this.jointsTableAdapter.Fill(this.db.Joints);

            // Ok, let's start to build our virtual robot arm !

          //  models = new List<DenavitHartenbergModel>();
           // arms = new List<DenavitHartenbergNode>();

           

            ucView = new ucView();
            ucView.Dock = DockStyle.Fill;
            sC.Panel2.Controls.Add(ucView);

     
            // Start the animation

            timer1.Interval = 100;

            refreshBtn_Click(sender, e);


            if (this.db.Models.Count==0)
            {
                this.db.Models.MakeAModel();
              //  this.db.Models.LinkModels();
            }

            // timer1.Enabled = true;
        }

    

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Let's move some joints to make a "hello" or "help meeee !" gesture !
            animateAsPlant(sender,e);

     
        }

        void animateAsPlant(object sender, EventArgs e)
        {


        double factor = 0.0001;
    


            foreach (DH.db.ModelsRow m in this.db.Models)
            {

           

                IEnumerable<DH.db.JointsRow> joints = m.GetJointsRows();


                foreach (DH.db.JointsRow j in joints)
                {

                 
                        angle += (float)Math.PI / 30;
                        j.theta = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);
                        j.alpha = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);
                        j.d += (j.d * (factor));
                        j.r += j.r * (factor);


                }



            


                // Add the second joint
                // model.Joints.Add(alpha: 0, theta: -Math.PI / 3, radius: 35, offset: 0);

                //   arm.Compute();

                // Compute the images for displaying on the picture boxes


            }


       //     model.Joints[0].Parameters.Theta = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);
        //    model.Joints[1].Parameters.Theta = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);


          //  model.Joints[2].Parameters.Theta = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);

            // Increment the animation time
         


            refreshBtn_Click(sender, e);

        }
        // Pause/Start button
        private void button1_Click(object sender, EventArgs e)
        {
            // Toggle animation
            timer1.Enabled = !timer1.Enabled;
        }

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
         //   arm.Children.Add(model_tgripper);

            // Add the bottom finger
        //    arm.Children.Add(model_bgripper);

         

            refreshBtn_Click(sender, e);


        }
     

     
        private void jointBtn_Click(object sender, EventArgs e)
        {
            // Add the first joint 

           DataRowView v =  this.modelsBindingSource.Current as DataRowView;

            DH.db.ModelsRow m = v.Row as DH.db.ModelsRow;

            this.db.Joints.MakeAJoint(m.ID);
      

            refreshBtn_Click(sender,e);

        }


     

        private void jointsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jointsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db);

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {

            this.db.Models.LinkModels();

            foreach (DH.db.ModelsRow m in this.db.Models)
            {

                ucView.Draw(m.Arm);

            }

        }
    }
}
