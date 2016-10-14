using System;
using System.Linq;
using Accord.Math;
using Accord.Math.Kinematics;

namespace DH
{
    public partial class db
    {

        /// <summary>
        /// Fill the tables with data from the SQL database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FillData()
        {
            // Start the animation

            // TODO: This line of code loads data into the 'db.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.Models);
            // TODO: This line of code loads data into the 'db.Joints' table. You can move, or remove it, as needed.
            this.freedomTableAdapter.Fill(this.Freedom);
            this.jointsTableAdapter.Fill(this.Joints);
            this.factorsTableAdapter.Fill(this.Factors);
        }
        public void Save()
        {

            this.tableAdapterManager.UpdateAll(this);

        }

        private dbTableAdapters.FreedomTableAdapter freedomTableAdapter;
        private dbTableAdapters.ImagesTableAdapter imagesTA;
        private dbTableAdapters.JointsTableAdapter jointsTableAdapter;
        private dbTableAdapters.TableAdapterManager tableAdapterManager;
        private dbTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private dbTableAdapters.FactorsTableAdapter factorsTableAdapter;


        public void CreateAdapters()
        {
     


            this.jointsTableAdapter = new DH.dbTableAdapters.JointsTableAdapter();
            this.tableAdapterManager = new DH.dbTableAdapters.TableAdapterManager();
            this.factorsTableAdapter = new DH.dbTableAdapters.FactorsTableAdapter();
            this.freedomTableAdapter = new DH.dbTableAdapters.FreedomTableAdapter();
            this.imagesTA = new DH.dbTableAdapters.ImagesTableAdapter();
            this.modelsTableAdapter = new DH.dbTableAdapters.ModelsTableAdapter();



            // 
            this.jointsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FactorsTableAdapter = this.factorsTableAdapter;
            this.tableAdapterManager.FreedomTableAdapter = this.freedomTableAdapter;
            this.tableAdapterManager.ImagesTableAdapter = this.imagesTA;
            this.tableAdapterManager.JointsTableAdapter = this.jointsTableAdapter;
            this.tableAdapterManager.ModelsTableAdapter = this.modelsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DH.dbTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // factorsTableAdapter
            // 
            this.factorsTableAdapter.ClearBeforeFill = true;
            // 
            // freedomTableAdapter
            // 
            this.freedomTableAdapter.ClearBeforeFill = true;
            // 
            // imagesTA
            // 
            this.imagesTA.ClearBeforeFill = true;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;




        }



     
    }
}