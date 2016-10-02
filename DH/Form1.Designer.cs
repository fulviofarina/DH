namespace DH
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.jointsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db = new DH.db();
            this.jointBtn = new System.Windows.Forms.Button();
            this.gripperBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.jointsTableAdapter = new DH.dbTableAdapters.JointsTableAdapter();
            this.tableAdapterManager = new DH.dbTableAdapters.TableAdapterManager();
            this.jointsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.jointsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sC = new System.Windows.Forms.SplitContainer();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelsTableAdapter = new DH.dbTableAdapters.ModelsTableAdapter();
            this.modelsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jointsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsBindingNavigator)).BeginInit();
            this.jointsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sC)).BeginInit();
            this.sC.Panel1.SuspendLayout();
            this.sC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1050, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pause/Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.91304F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.905371F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.161125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.93521F));
            this.tableLayoutPanel1.Controls.Add(this.modelsDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.jointsDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.jointBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gripperBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 407);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.09898F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.90102F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1190, 480);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // jointsDataGridView
            // 
            this.jointsDataGridView.AutoGenerateColumns = false;
            this.jointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn2});
            this.jointsDataGridView.DataSource = this.jointsBindingSource;
            this.jointsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jointsDataGridView.Location = new System.Drawing.Point(3, 229);
            this.jointsDataGridView.Name = "jointsDataGridView";
            this.jointsDataGridView.Size = new System.Drawing.Size(874, 248);
            this.jointsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nr";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nr";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "theta";
            this.dataGridViewTextBoxColumn5.HeaderText = "theta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "d";
            this.dataGridViewTextBoxColumn6.HeaderText = "d";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "r";
            this.dataGridViewTextBoxColumn7.HeaderText = "r";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "alpha";
            this.dataGridViewTextBoxColumn8.HeaderText = "alpha";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ModelID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ModelID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // jointsBindingSource
            // 
            this.jointsBindingSource.DataMember = "Joints";
            this.jointsBindingSource.DataSource = this.db;
            // 
            // db
            // 
            this.db.DataSetName = "db";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jointBtn
            // 
            this.jointBtn.Location = new System.Drawing.Point(965, 3);
            this.jointBtn.Name = "jointBtn";
            this.jointBtn.Size = new System.Drawing.Size(75, 23);
            this.jointBtn.TabIndex = 0;
            this.jointBtn.Text = "add joint";
            this.jointBtn.UseVisualStyleBackColor = true;
            this.jointBtn.Click += new System.EventHandler(this.jointBtn_Click);
            // 
            // gripperBtn
            // 
            this.gripperBtn.Location = new System.Drawing.Point(883, 3);
            this.gripperBtn.Name = "gripperBtn";
            this.gripperBtn.Size = new System.Drawing.Size(75, 23);
            this.gripperBtn.TabIndex = 1;
            this.gripperBtn.Text = "add gripper";
            this.gripperBtn.UseVisualStyleBackColor = true;
            this.gripperBtn.Click += new System.EventHandler(this.gripperBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(28, 21);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // jointsTableAdapter
            // 
            this.jointsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JointsTableAdapter = this.jointsTableAdapter;
            this.tableAdapterManager.ModelsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DH.dbTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // jointsBindingNavigator
            // 
            this.jointsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jointsBindingNavigator.BindingSource = this.jointsBindingSource;
            this.jointsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jointsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jointsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.jointsBindingNavigatorSaveItem});
            this.jointsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jointsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jointsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jointsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jointsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jointsBindingNavigator.Name = "jointsBindingNavigator";
            this.jointsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jointsBindingNavigator.Size = new System.Drawing.Size(1202, 25);
            this.jointsBindingNavigator.TabIndex = 6;
            this.jointsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // jointsBindingNavigatorSaveItem
            // 
            this.jointsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jointsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jointsBindingNavigatorSaveItem.Image")));
            this.jointsBindingNavigatorSaveItem.Name = "jointsBindingNavigatorSaveItem";
            this.jointsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.jointsBindingNavigatorSaveItem.Text = "Save Data";
            this.jointsBindingNavigatorSaveItem.Click += new System.EventHandler(this.jointsBindingNavigatorSaveItem_Click);
            // 
            // sC
            // 
            this.sC.Location = new System.Drawing.Point(12, 28);
            this.sC.Name = "sC";
            // 
            // sC.Panel1
            // 
            this.sC.Panel1.Controls.Add(this.refreshBtn);
            this.sC.Size = new System.Drawing.Size(1173, 373);
            this.sC.SplitterDistance = 124;
            this.sC.TabIndex = 7;
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.db;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // modelsDataGridView
            // 
            this.modelsDataGridView.AutoGenerateColumns = false;
            this.modelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.modelsDataGridView.DataSource = this.modelsBindingSource;
            this.modelsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.modelsDataGridView.Name = "modelsDataGridView";
            this.modelsDataGridView.Size = new System.Drawing.Size(874, 220);
            this.modelsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ModelType";
            this.dataGridViewTextBoxColumn10.HeaderText = "ModelType";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "x";
            this.dataGridViewTextBoxColumn11.HeaderText = "x";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "y";
            this.dataGridViewTextBoxColumn12.HeaderText = "y";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "z";
            this.dataGridViewTextBoxColumn13.HeaderText = "z";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1202, 887);
            this.Controls.Add(this.sC);
            this.Controls.Add(this.jointsBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Denavit Hartenberg";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jointsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsBindingNavigator)).EndInit();
            this.jointsBindingNavigator.ResumeLayout(false);
            this.jointsBindingNavigator.PerformLayout();
            this.sC.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sC)).EndInit();
            this.sC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button gripperBtn;
        private System.Windows.Forms.Button jointBtn;
        private db db;
        private System.Windows.Forms.BindingSource jointsBindingSource;
        private dbTableAdapters.JointsTableAdapter jointsTableAdapter;
        private dbTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jointsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton jointsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView jointsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.SplitContainer sC;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private dbTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.DataGridView modelsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}

