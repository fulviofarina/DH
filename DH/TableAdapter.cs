using DH.dbTableAdapters;

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
            tableAdapterManager.ModelsTableAdapter.Fill(Models);
            // TODO: This line of code loads data into the 'db.Joints' table. You can move, or remove it, as needed.
            tableAdapterManager.FreedomTableAdapter.Fill(Freedom);
            tableAdapterManager.JointsTableAdapter.Fill(Joints);
            tableAdapterManager.FactorsTableAdapter.Fill(Factors);
        }

        /// <summary>
        /// saves the database
        /// </summary>
        public void Save()
        {
            tableAdapterManager.UpdateAll(this);
        }

        private TableAdapterManager tableAdapterManager;

        /// <summary>
        /// creates the table adapaters for SQL query, fill and save
        /// </summary>
        public void CreateAdapters()
        {
            FreedomTableAdapter freedomTableAdapter;
            ImagesTableAdapter imagesTA;
            JointsTableAdapter jointsTableAdapter;

            ModelsTableAdapter modelsTableAdapter;
            FactorsTableAdapter factorsTableAdapter;

            jointsTableAdapter = new JointsTableAdapter();
            tableAdapterManager = new TableAdapterManager();
            factorsTableAdapter = new FactorsTableAdapter();
            freedomTableAdapter = new FreedomTableAdapter();
            imagesTA = new ImagesTableAdapter();
            modelsTableAdapter = new ModelsTableAdapter();

            //
            // factorsTableAdapter
            //
            factorsTableAdapter.ClearBeforeFill = true;
            //
            // freedomTableAdapter
            //
            freedomTableAdapter.ClearBeforeFill = true;
            //
            // imagesTA
            //
            imagesTA.ClearBeforeFill = true;
            //
            // modelsTableAdapter
            //
            modelsTableAdapter.ClearBeforeFill = true;

            //
            jointsTableAdapter.ClearBeforeFill = true;
            //
            // tableAdapterManager
            //
            tableAdapterManager.BackupDataSetBeforeUpdate = false;
            tableAdapterManager.FactorsTableAdapter = factorsTableAdapter;
            tableAdapterManager.FreedomTableAdapter = freedomTableAdapter;
            tableAdapterManager.ImagesTableAdapter = imagesTA;
            tableAdapterManager.JointsTableAdapter = jointsTableAdapter;
            tableAdapterManager.ModelsTableAdapter = modelsTableAdapter;
            tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
        }
    }
}