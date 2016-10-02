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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.factorsDGV = new System.Windows.Forms.DataGridView();
            this.pointEndDGV = new System.Windows.Forms.DataGridView();
            this.freedomDataGridView = new System.Windows.Forms.DataGridView();
            this.modelsDataGridView = new System.Windows.Forms.DataGridView();
            this.jointsDataGridView = new System.Windows.Forms.DataGridView();
            this.modelBtn = new System.Windows.Forms.Button();
            this.jointBtn = new System.Windows.Forms.Button();
            this.gripperBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
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
            this.clean = new System.Windows.Forms.ToolStripButton();
            this.sC = new System.Windows.Forms.SplitContainer();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.jointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db = new DH.db();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastPointBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointEndBS = new System.Windows.Forms.BindingSource(this.components);
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jointIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alphaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorsBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.freedomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jointsTableAdapter = new DH.dbTableAdapters.JointsTableAdapter();
            this.tableAdapterManager = new DH.dbTableAdapters.TableAdapterManager();
            this.factorsTableAdapter = new DH.dbTableAdapters.FactorsTableAdapter();
            this.freedomTableAdapter = new DH.dbTableAdapters.FreedomTableAdapter();
            this.modelsTableAdapter = new DH.dbTableAdapters.ModelsTableAdapter();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PathCntBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointEndDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freedomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsBindingNavigator)).BeginInit();
            this.jointsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sC)).BeginInit();
            this.sC.Panel1.SuspendLayout();
            this.sC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jointsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastPointBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointEndBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freedomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pause/Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.9834F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.79668F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.167237F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pointEndDGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.modelsDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.jointsDataGridView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.modelBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PathCntBox, 2, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 407);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.220779F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.20626F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.25974F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.402597F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.493506F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.55844F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1205, 770);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.dataGridView1.DataSource = this.lastPointBS;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 65);
            this.dataGridView1.TabIndex = 9;
            // 
            // factorsDGV
            // 
            this.factorsDGV.AllowUserToAddRows = false;
            this.factorsDGV.AutoGenerateColumns = false;
            this.factorsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.factorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.factorsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.jointIDDataGridViewTextBoxColumn,
            this.thetaDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.rDataGridViewTextBoxColumn,
            this.alphaDataGridViewTextBoxColumn});
            this.factorsDGV.DataSource = this.factorsBS;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.factorsDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.factorsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.factorsDGV.Location = new System.Drawing.Point(0, 0);
            this.factorsDGV.MultiSelect = false;
            this.factorsDGV.Name = "factorsDGV";
            this.factorsDGV.Size = new System.Drawing.Size(341, 75);
            this.factorsDGV.TabIndex = 8;
            // 
            // pointEndDGV
            // 
            this.pointEndDGV.AllowUserToAddRows = false;
            this.pointEndDGV.AutoGenerateColumns = false;
            this.pointEndDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointEndDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.pointEndDGV.DataSource = this.pointEndBS;
            this.pointEndDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointEndDGV.Location = new System.Drawing.Point(3, 74);
            this.pointEndDGV.Name = "pointEndDGV";
            this.pointEndDGV.Size = new System.Drawing.Size(765, 92);
            this.pointEndDGV.TabIndex = 7;
            this.pointEndDGV.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.modelsDataGridView_CellBeginEdit);
            this.pointEndDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.pointEndDGV_CellEndEdit);
            // 
            // freedomDataGridView
            // 
            this.freedomDataGridView.AllowUserToAddRows = false;
            this.freedomDataGridView.AutoGenerateColumns = false;
            this.freedomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.freedomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.freedomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.freedomDataGridView.DataSource = this.freedomBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.freedomDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.freedomDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freedomDataGridView.Location = new System.Drawing.Point(0, 0);
            this.freedomDataGridView.MultiSelect = false;
            this.freedomDataGridView.Name = "freedomDataGridView";
            this.freedomDataGridView.Size = new System.Drawing.Size(341, 71);
            this.freedomDataGridView.TabIndex = 6;
            this.freedomDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.modelsDataGridView_CellBeginEdit);
            this.freedomDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.pointEndDGV_CellEndEdit);
            // 
            // modelsDataGridView
            // 
            this.modelsDataGridView.AllowUserToAddRows = false;
            this.modelsDataGridView.AutoGenerateColumns = false;
            this.modelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.Show});
            this.modelsDataGridView.DataSource = this.modelsBindingSource;
            this.modelsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelsDataGridView.Location = new System.Drawing.Point(3, 172);
            this.modelsDataGridView.Name = "modelsDataGridView";
            this.modelsDataGridView.Size = new System.Drawing.Size(765, 88);
            this.modelsDataGridView.TabIndex = 4;
            this.modelsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.modelsDataGridView_CellBeginEdit);
            this.modelsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.pointEndDGV_CellEndEdit);
            this.modelsDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.modelsDataGridView_RowHeaderMouseClick);
            // 
            // jointsDataGridView
            // 
            this.jointsDataGridView.AllowUserToAddRows = false;
            this.jointsDataGridView.AutoGenerateColumns = false;
            this.jointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn5});
            this.jointsDataGridView.DataSource = this.jointsBindingSource;
            this.jointsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jointsDataGridView.Location = new System.Drawing.Point(3, 266);
            this.jointsDataGridView.Name = "jointsDataGridView";
            this.jointsDataGridView.Size = new System.Drawing.Size(765, 150);
            this.jointsDataGridView.TabIndex = 2;
            this.jointsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.modelsDataGridView_CellBeginEdit);
            this.jointsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.pointEndDGV_CellEndEdit);
            this.jointsDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.modelsDataGridView_RowHeaderMouseClick);
            // 
            // modelBtn
            // 
            this.modelBtn.Location = new System.Drawing.Point(774, 172);
            this.modelBtn.Name = "modelBtn";
            this.modelBtn.Size = new System.Drawing.Size(174, 35);
            this.modelBtn.TabIndex = 5;
            this.modelBtn.Text = "add model";
            this.modelBtn.UseVisualStyleBackColor = true;
            this.modelBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // jointBtn
            // 
            this.jointBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jointBtn.Location = new System.Drawing.Point(0, 0);
            this.jointBtn.Name = "jointBtn";
            this.jointBtn.Size = new System.Drawing.Size(81, 70);
            this.jointBtn.TabIndex = 0;
            this.jointBtn.Text = "add joint";
            this.jointBtn.UseVisualStyleBackColor = true;
            this.jointBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // gripperBtn
            // 
            this.gripperBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gripperBtn.Location = new System.Drawing.Point(0, 0);
            this.gripperBtn.Name = "gripperBtn";
            this.gripperBtn.Size = new System.Drawing.Size(81, 76);
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
            this.jointsBindingNavigatorSaveItem,
            this.clean});
            this.jointsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jointsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jointsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jointsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jointsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jointsBindingNavigator.Name = "jointsBindingNavigator";
            this.jointsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jointsBindingNavigator.Size = new System.Drawing.Size(1234, 25);
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
            // clean
            // 
            this.clean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clean.Image = ((System.Drawing.Image)(resources.GetObject("clean.Image")));
            this.clean.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(41, 22);
            this.clean.Text = "Clean";
            this.clean.Click += new System.EventHandler(this.clean_Click);
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
            // timeBox
            // 
            this.timeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeBox.Location = new System.Drawing.Point(0, 0);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(81, 29);
            this.timeBox.TabIndex = 10;
            this.timeBox.Text = "50";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(774, 266);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.factorsDGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.freedomDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(341, 150);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(1121, 266);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.jointBtn);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gripperBtn);
            this.splitContainer2.Size = new System.Drawing.Size(81, 150);
            this.splitContainer2.SplitterDistance = 70;
            this.splitContainer2.TabIndex = 12;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(1121, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.timeBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.button1);
            this.splitContainer3.Size = new System.Drawing.Size(81, 65);
            this.splitContainer3.SplitterDistance = 27;
            this.splitContainer3.TabIndex = 13;
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
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn21.HeaderText = "ID";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "ModelType";
            this.dataGridViewTextBoxColumn22.HeaderText = "ModelType";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "x";
            this.dataGridViewTextBoxColumn23.HeaderText = "x";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "y";
            this.dataGridViewTextBoxColumn24.HeaderText = "y";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "z";
            this.dataGridViewTextBoxColumn25.HeaderText = "z";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // lastPointBS
            // 
            this.lastPointBS.DataMember = "Models";
            this.lastPointBS.DataSource = this.db;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn16.HeaderText = "ID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ModelType";
            this.dataGridViewTextBoxColumn17.HeaderText = "ModelType";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "x";
            this.dataGridViewTextBoxColumn18.HeaderText = "x";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "y";
            this.dataGridViewTextBoxColumn19.HeaderText = "y";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "z";
            this.dataGridViewTextBoxColumn20.HeaderText = "z";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // pointEndBS
            // 
            this.pointEndBS.DataMember = "Models";
            this.pointEndBS.DataSource = this.db;
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.db;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // jointIDDataGridViewTextBoxColumn
            // 
            this.jointIDDataGridViewTextBoxColumn.DataPropertyName = "JointID";
            this.jointIDDataGridViewTextBoxColumn.HeaderText = "JointID";
            this.jointIDDataGridViewTextBoxColumn.Name = "jointIDDataGridViewTextBoxColumn";
            this.jointIDDataGridViewTextBoxColumn.Visible = false;
            this.jointIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // thetaDataGridViewTextBoxColumn
            // 
            this.thetaDataGridViewTextBoxColumn.DataPropertyName = "theta";
            this.thetaDataGridViewTextBoxColumn.HeaderText = "theta";
            this.thetaDataGridViewTextBoxColumn.Name = "thetaDataGridViewTextBoxColumn";
            this.thetaDataGridViewTextBoxColumn.Width = 70;
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "d";
            this.dDataGridViewTextBoxColumn.HeaderText = "d";
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            this.dDataGridViewTextBoxColumn.Width = 44;
            // 
            // rDataGridViewTextBoxColumn
            // 
            this.rDataGridViewTextBoxColumn.DataPropertyName = "r";
            this.rDataGridViewTextBoxColumn.HeaderText = "r";
            this.rDataGridViewTextBoxColumn.Name = "rDataGridViewTextBoxColumn";
            this.rDataGridViewTextBoxColumn.Width = 41;
            // 
            // alphaDataGridViewTextBoxColumn
            // 
            this.alphaDataGridViewTextBoxColumn.DataPropertyName = "alpha";
            this.alphaDataGridViewTextBoxColumn.HeaderText = "alpha";
            this.alphaDataGridViewTextBoxColumn.Name = "alphaDataGridViewTextBoxColumn";
            this.alphaDataGridViewTextBoxColumn.Width = 73;
            // 
            // factorsBS
            // 
            this.factorsBS.DataMember = "Factors";
            this.factorsBS.DataSource = this.db;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn14.HeaderText = "ID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 43;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "JointID";
            this.dataGridViewTextBoxColumn15.HeaderText = "JointID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            this.dataGridViewTextBoxColumn15.Width = 65;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "theta";
            this.dataGridViewCheckBoxColumn1.HeaderText = "theta";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 51;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "d";
            this.dataGridViewCheckBoxColumn2.HeaderText = "d";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 25;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "r";
            this.dataGridViewCheckBoxColumn3.HeaderText = "r";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 22;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "alpha";
            this.dataGridViewCheckBoxColumn4.HeaderText = "alpha";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Width = 54;
            // 
            // freedomBindingSource
            // 
            this.freedomBindingSource.DataMember = "Freedom";
            this.freedomBindingSource.DataSource = this.db;
            // 
            // jointsTableAdapter
            // 
            this.jointsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FactorsTableAdapter = this.factorsTableAdapter;
            this.tableAdapterManager.FreedomTableAdapter = this.freedomTableAdapter;
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
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
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
            // Show
            // 
            this.Show.DataPropertyName = "Show";
            this.Show.HeaderText = "Show";
            this.Show.Name = "Show";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nr";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nr";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "Show";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Show";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            // 
            // PathCntBox
            // 
            this.PathCntBox.Location = new System.Drawing.Point(1121, 74);
            this.PathCntBox.Name = "PathCntBox";
            this.PathCntBox.Size = new System.Drawing.Size(81, 29);
            this.PathCntBox.TabIndex = 14;
            this.PathCntBox.Text = "500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1251, 1053);
            this.Controls.Add(this.sC);
            this.Controls.Add(this.jointsBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Denavit Hartenberg";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointEndDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freedomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsBindingNavigator)).EndInit();
            this.jointsBindingNavigator.ResumeLayout(false);
            this.jointsBindingNavigator.PerformLayout();
            this.sC.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sC)).EndInit();
            this.sC.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jointsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastPointBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointEndBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freedomBindingSource)).EndInit();
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
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.SplitContainer sC;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private dbTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.DataGridView modelsDataGridView;
        private System.Windows.Forms.Button modelBtn;
        private System.Windows.Forms.ToolStripButton clean;
        private System.Windows.Forms.BindingSource freedomBindingSource;
        private dbTableAdapters.FreedomTableAdapter freedomTableAdapter;
        private System.Windows.Forms.DataGridView freedomDataGridView;
        private System.Windows.Forms.DataGridView pointEndDGV;
        private System.Windows.Forms.BindingSource pointEndBS;
        private System.Windows.Forms.DataGridView factorsDGV;
        private System.Windows.Forms.BindingSource factorsBS;
        private dbTableAdapters.FactorsTableAdapter factorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jointIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alphaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lastPointBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Show;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.TextBox PathCntBox;
    }
}

