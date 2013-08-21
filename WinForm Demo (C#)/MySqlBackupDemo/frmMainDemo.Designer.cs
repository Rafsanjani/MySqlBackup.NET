namespace MySqlBackupDemo
{
    partial class frmMainDemo
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
            this.btAll = new System.Windows.Forms.Button();
            this.btNone = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colnTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnSql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btExpand = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbImportErr = new System.Windows.Forms.Label();
            this.lbTotalBytes = new System.Windows.Forms.Label();
            this.pbBytes = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pgGetTotalRows = new System.Windows.Forms.ProgressBar();
            this.lbTotalTableDB = new System.Windows.Forms.Label();
            this.lbGetTotalRows = new System.Windows.Forms.Label();
            this.lbCurrentTable = new System.Windows.Forms.Label();
            this.pbRowsTable = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbTable = new System.Windows.Forms.ProgressBar();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.lbRowProgressDB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbPercent = new System.Windows.Forms.ProgressBar();
            this.pbRowsDB = new System.Windows.Forms.ProgressBar();
            this.lbRowProgressCurTable = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbRecordDumpTime = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nmSQLLength = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAutoCloseConnectionExport = new System.Windows.Forms.CheckBox();
            this.cbExProcedure = new System.Windows.Forms.CheckBox();
            this.cbExViews = new System.Windows.Forms.CheckBox();
            this.cbExFunction = new System.Windows.Forms.CheckBox();
            this.txtEncryptionKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbExEvent = new System.Windows.Forms.CheckBox();
            this.cbEnableEncryption = new System.Windows.Forms.CheckBox();
            this.cbAsynchronousModeExport = new System.Windows.Forms.CheckBox();
            this.cbExTrigger = new System.Windows.Forms.CheckBox();
            this.cbAddCreateDatabase = new System.Windows.Forms.CheckBox();
            this.cbExportTableStructure = new System.Windows.Forms.CheckBox();
            this.cbCalculateTotalRowsFromDatabase = new System.Windows.Forms.CheckBox();
            this.cbResetAutoIncrement = new System.Windows.Forms.CheckBox();
            this.cbExportRows = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbCharSet = new System.Windows.Forms.ComboBox();
            this.cbImAutoCloseConnection = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTargetDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImEncryptKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbImAsyn = new System.Windows.Forms.CheckBox();
            this.cbImIgnoreSqlError = new System.Windows.Forms.CheckBox();
            this.cbImEnableEncrypt = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbHashResult = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHash2 = new System.Windows.Forms.TextBox();
            this.txtHashFile2 = new System.Windows.Forms.TextBox();
            this.txtHash1 = new System.Windows.Forms.TextBox();
            this.txtHashFile1 = new System.Windows.Forms.TextBox();
            this.btHashFile2 = new System.Windows.Forms.Button();
            this.btHashFile1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDeleteAllRows = new System.Windows.Forms.Button();
            this.btCancelImport = new System.Windows.Forms.Button();
            this.btCancelExport = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.cbZip = new System.Windows.Forms.CheckBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSQLLength)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAll
            // 
            this.btAll.Location = new System.Drawing.Point(3, 3);
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(44, 23);
            this.btAll.TabIndex = 0;
            this.btAll.Text = "All";
            this.btAll.UseVisualStyleBackColor = true;
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // btNone
            // 
            this.btNone.Location = new System.Drawing.Point(53, 3);
            this.btNone.Name = "btNone";
            this.btNone.Size = new System.Drawing.Size(44, 23);
            this.btNone.TabIndex = 1;
            this.btNone.Text = "None";
            this.btNone.UseVisualStyleBackColor = true;
            this.btNone.Click += new System.EventHandler(this.btNone_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(884, 662);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnSelect,
            this.colnTable,
            this.colnSql});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(237, 612);
            this.dataGridView1.TabIndex = 4;
            // 
            // colnSelect
            // 
            this.colnSelect.HeaderText = "";
            this.colnSelect.Name = "colnSelect";
            this.colnSelect.Width = 30;
            // 
            // colnTable
            // 
            this.colnTable.HeaderText = "Table";
            this.colnTable.Name = "colnTable";
            this.colnTable.Width = 170;
            // 
            // colnSql
            // 
            this.colnSql.HeaderText = "SQL";
            this.colnSql.Name = "colnSql";
            this.colnSql.Width = 600;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btExpand);
            this.panel1.Controls.Add(this.btAll);
            this.panel1.Controls.Add(this.btNone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 50);
            this.panel1.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "None = All";
            // 
            // btExpand
            // 
            this.btExpand.Location = new System.Drawing.Point(103, 3);
            this.btExpand.Name = "btExpand";
            this.btExpand.Size = new System.Drawing.Size(75, 23);
            this.btExpand.TabIndex = 4;
            this.btExpand.Text = "Expand";
            this.btExpand.UseVisualStyleBackColor = true;
            this.btExpand.Click += new System.EventHandler(this.btExpand_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbImportErr);
            this.groupBox2.Controls.Add(this.lbTotalBytes);
            this.groupBox2.Controls.Add(this.pbBytes);
            this.groupBox2.Location = new System.Drawing.Point(10, 525);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 125);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import Progress";
            // 
            // lbImportErr
            // 
            this.lbImportErr.AutoSize = true;
            this.lbImportErr.Location = new System.Drawing.Point(46, 89);
            this.lbImportErr.Name = "lbImportErr";
            this.lbImportErr.Size = new System.Drawing.Size(0, 13);
            this.lbImportErr.TabIndex = 4;
            // 
            // lbTotalBytes
            // 
            this.lbTotalBytes.AutoSize = true;
            this.lbTotalBytes.Location = new System.Drawing.Point(50, 34);
            this.lbTotalBytes.Name = "lbTotalBytes";
            this.lbTotalBytes.Size = new System.Drawing.Size(0, 13);
            this.lbTotalBytes.TabIndex = 3;
            // 
            // pbBytes
            // 
            this.pbBytes.Location = new System.Drawing.Point(47, 50);
            this.pbBytes.Name = "pbBytes";
            this.pbBytes.Size = new System.Drawing.Size(531, 23);
            this.pbBytes.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pgGetTotalRows);
            this.groupBox1.Controls.Add(this.lbTotalTableDB);
            this.groupBox1.Controls.Add(this.lbGetTotalRows);
            this.groupBox1.Controls.Add(this.lbCurrentTable);
            this.groupBox1.Controls.Add(this.pbRowsTable);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pbTable);
            this.groupBox1.Controls.Add(this.lbPercentage);
            this.groupBox1.Controls.Add(this.lbRowProgressDB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pbPercent);
            this.groupBox1.Controls.Add(this.pbRowsDB);
            this.groupBox1.Controls.Add(this.lbRowProgressCurTable);
            this.groupBox1.Location = new System.Drawing.Point(10, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 227);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Progress";
            // 
            // pgGetTotalRows
            // 
            this.pgGetTotalRows.Location = new System.Drawing.Point(47, 44);
            this.pgGetTotalRows.Name = "pgGetTotalRows";
            this.pgGetTotalRows.Size = new System.Drawing.Size(531, 23);
            this.pgGetTotalRows.TabIndex = 70;
            // 
            // lbTotalTableDB
            // 
            this.lbTotalTableDB.AutoSize = true;
            this.lbTotalTableDB.Location = new System.Drawing.Point(401, 174);
            this.lbTotalTableDB.Name = "lbTotalTableDB";
            this.lbTotalTableDB.Size = new System.Drawing.Size(0, 13);
            this.lbTotalTableDB.TabIndex = 67;
            // 
            // lbGetTotalRows
            // 
            this.lbGetTotalRows.AutoSize = true;
            this.lbGetTotalRows.Location = new System.Drawing.Point(46, 28);
            this.lbGetTotalRows.Name = "lbGetTotalRows";
            this.lbGetTotalRows.Size = new System.Drawing.Size(0, 13);
            this.lbGetTotalRows.TabIndex = 71;
            // 
            // lbCurrentTable
            // 
            this.lbCurrentTable.AutoSize = true;
            this.lbCurrentTable.Location = new System.Drawing.Point(120, 154);
            this.lbCurrentTable.Name = "lbCurrentTable";
            this.lbCurrentTable.Size = new System.Drawing.Size(0, 13);
            this.lbCurrentTable.TabIndex = 59;
            // 
            // pbRowsTable
            // 
            this.pbRowsTable.Location = new System.Drawing.Point(47, 190);
            this.pbRowsTable.Name = "pbRowsTable";
            this.pbRowsTable.Size = new System.Drawing.Size(249, 23);
            this.pbRowsTable.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Total Tables:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Current Table:";
            // 
            // pbTable
            // 
            this.pbTable.Location = new System.Drawing.Point(329, 190);
            this.pbTable.Name = "pbTable";
            this.pbTable.Size = new System.Drawing.Size(249, 23);
            this.pbTable.TabIndex = 65;
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Location = new System.Drawing.Point(51, 103);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(0, 13);
            this.lbPercentage.TabIndex = 69;
            // 
            // lbRowProgressDB
            // 
            this.lbRowProgressDB.AutoSize = true;
            this.lbRowProgressDB.Location = new System.Drawing.Point(401, 103);
            this.lbRowProgressDB.Name = "lbRowProgressDB";
            this.lbRowProgressDB.Size = new System.Drawing.Size(0, 13);
            this.lbRowProgressDB.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Rows:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Total Rows:";
            // 
            // pbPercent
            // 
            this.pbPercent.Location = new System.Drawing.Point(47, 119);
            this.pbPercent.Name = "pbPercent";
            this.pbPercent.Size = new System.Drawing.Size(249, 23);
            this.pbPercent.TabIndex = 68;
            // 
            // pbRowsDB
            // 
            this.pbRowsDB.Location = new System.Drawing.Point(329, 119);
            this.pbRowsDB.MarqueeAnimationSpeed = 1000;
            this.pbRowsDB.Name = "pbRowsDB";
            this.pbRowsDB.Size = new System.Drawing.Size(249, 23);
            this.pbRowsDB.TabIndex = 62;
            // 
            // lbRowProgressCurTable
            // 
            this.lbRowProgressCurTable.AutoSize = true;
            this.lbRowProgressCurTable.Location = new System.Drawing.Point(120, 174);
            this.lbRowProgressCurTable.Name = "lbRowProgressCurTable";
            this.lbRowProgressCurTable.Size = new System.Drawing.Size(0, 13);
            this.lbRowProgressCurTable.TabIndex = 61;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 175);
            this.tabControl1.TabIndex = 55;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbZip);
            this.tabPage1.Controls.Add(this.cbRecordDumpTime);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.nmSQLLength);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbAutoCloseConnectionExport);
            this.tabPage1.Controls.Add(this.cbExProcedure);
            this.tabPage1.Controls.Add(this.cbExViews);
            this.tabPage1.Controls.Add(this.cbExFunction);
            this.tabPage1.Controls.Add(this.txtEncryptionKey);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbExEvent);
            this.tabPage1.Controls.Add(this.cbEnableEncryption);
            this.tabPage1.Controls.Add(this.cbAsynchronousModeExport);
            this.tabPage1.Controls.Add(this.cbExTrigger);
            this.tabPage1.Controls.Add(this.cbAddCreateDatabase);
            this.tabPage1.Controls.Add(this.cbExportTableStructure);
            this.tabPage1.Controls.Add(this.cbCalculateTotalRowsFromDatabase);
            this.tabPage1.Controls.Add(this.cbResetAutoIncrement);
            this.tabPage1.Controls.Add(this.cbExportRows);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Export Informations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbRecordDumpTime
            // 
            this.cbRecordDumpTime.AutoSize = true;
            this.cbRecordDumpTime.Checked = true;
            this.cbRecordDumpTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRecordDumpTime.Location = new System.Drawing.Point(399, 29);
            this.cbRecordDumpTime.Name = "cbRecordDumpTime";
            this.cbRecordDumpTime.Size = new System.Drawing.Size(118, 17);
            this.cbRecordDumpTime.TabIndex = 65;
            this.cbRecordDumpTime.Text = "Record Dump Time";
            this.cbRecordDumpTime.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(421, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Default Length: 1MB (1024 x 1024)";
            // 
            // nmSQLLength
            // 
            this.nmSQLLength.Location = new System.Drawing.Point(537, 72);
            this.nmSQLLength.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nmSQLLength.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nmSQLLength.Name = "nmSQLLength";
            this.nmSQLLength.Size = new System.Drawing.Size(84, 20);
            this.nmSQLLength.TabIndex = 62;
            this.nmSQLLength.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Max Exported SQL Length:";
            // 
            // cbAutoCloseConnectionExport
            // 
            this.cbAutoCloseConnectionExport.AutoSize = true;
            this.cbAutoCloseConnectionExport.Checked = true;
            this.cbAutoCloseConnectionExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoCloseConnectionExport.Location = new System.Drawing.Point(399, 6);
            this.cbAutoCloseConnectionExport.Name = "cbAutoCloseConnectionExport";
            this.cbAutoCloseConnectionExport.Size = new System.Drawing.Size(134, 17);
            this.cbAutoCloseConnectionExport.TabIndex = 60;
            this.cbAutoCloseConnectionExport.Text = "Auto Close Connection";
            this.cbAutoCloseConnectionExport.UseVisualStyleBackColor = true;
            // 
            // cbExProcedure
            // 
            this.cbExProcedure.AutoSize = true;
            this.cbExProcedure.Checked = true;
            this.cbExProcedure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExProcedure.Location = new System.Drawing.Point(229, 6);
            this.cbExProcedure.Name = "cbExProcedure";
            this.cbExProcedure.Size = new System.Drawing.Size(147, 17);
            this.cbExProcedure.TabIndex = 55;
            this.cbExProcedure.Text = "Export Stored Procedures";
            this.cbExProcedure.UseVisualStyleBackColor = true;
            // 
            // cbExViews
            // 
            this.cbExViews.AutoSize = true;
            this.cbExViews.Checked = true;
            this.cbExViews.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExViews.Location = new System.Drawing.Point(229, 98);
            this.cbExViews.Name = "cbExViews";
            this.cbExViews.Size = new System.Drawing.Size(87, 17);
            this.cbExViews.TabIndex = 59;
            this.cbExViews.Text = "Export Views";
            this.cbExViews.UseVisualStyleBackColor = true;
            // 
            // cbExFunction
            // 
            this.cbExFunction.AutoSize = true;
            this.cbExFunction.Checked = true;
            this.cbExFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExFunction.Location = new System.Drawing.Point(229, 29);
            this.cbExFunction.Name = "cbExFunction";
            this.cbExFunction.Size = new System.Drawing.Size(105, 17);
            this.cbExFunction.TabIndex = 56;
            this.cbExFunction.Text = "Export Functions";
            this.cbExFunction.UseVisualStyleBackColor = true;
            // 
            // txtEncryptionKey
            // 
            this.txtEncryptionKey.Location = new System.Drawing.Point(447, 120);
            this.txtEncryptionKey.Name = "txtEncryptionKey";
            this.txtEncryptionKey.Size = new System.Drawing.Size(122, 20);
            this.txtEncryptionKey.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Encrypt Key:";
            // 
            // cbExEvent
            // 
            this.cbExEvent.AutoSize = true;
            this.cbExEvent.Checked = true;
            this.cbExEvent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExEvent.Location = new System.Drawing.Point(229, 75);
            this.cbExEvent.Name = "cbExEvent";
            this.cbExEvent.Size = new System.Drawing.Size(92, 17);
            this.cbExEvent.TabIndex = 58;
            this.cbExEvent.Text = "Export Events";
            this.cbExEvent.UseVisualStyleBackColor = true;
            // 
            // cbEnableEncryption
            // 
            this.cbEnableEncryption.AutoSize = true;
            this.cbEnableEncryption.Location = new System.Drawing.Point(229, 121);
            this.cbEnableEncryption.Name = "cbEnableEncryption";
            this.cbEnableEncryption.Size = new System.Drawing.Size(112, 17);
            this.cbEnableEncryption.TabIndex = 47;
            this.cbEnableEncryption.Text = "Enable Encryption";
            this.cbEnableEncryption.UseVisualStyleBackColor = true;
            // 
            // cbAsynchronousModeExport
            // 
            this.cbAsynchronousModeExport.AutoSize = true;
            this.cbAsynchronousModeExport.Checked = true;
            this.cbAsynchronousModeExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAsynchronousModeExport.Location = new System.Drawing.Point(6, 6);
            this.cbAsynchronousModeExport.Name = "cbAsynchronousModeExport";
            this.cbAsynchronousModeExport.Size = new System.Drawing.Size(123, 17);
            this.cbAsynchronousModeExport.TabIndex = 54;
            this.cbAsynchronousModeExport.Text = "Asynchronous Mode";
            this.cbAsynchronousModeExport.UseVisualStyleBackColor = true;
            // 
            // cbExTrigger
            // 
            this.cbExTrigger.AutoSize = true;
            this.cbExTrigger.Checked = true;
            this.cbExTrigger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExTrigger.Location = new System.Drawing.Point(229, 52);
            this.cbExTrigger.Name = "cbExTrigger";
            this.cbExTrigger.Size = new System.Drawing.Size(97, 17);
            this.cbExTrigger.TabIndex = 57;
            this.cbExTrigger.Text = "Export Triggers";
            this.cbExTrigger.UseVisualStyleBackColor = true;
            // 
            // cbAddCreateDatabase
            // 
            this.cbAddCreateDatabase.AutoSize = true;
            this.cbAddCreateDatabase.Location = new System.Drawing.Point(6, 29);
            this.cbAddCreateDatabase.Name = "cbAddCreateDatabase";
            this.cbAddCreateDatabase.Size = new System.Drawing.Size(200, 17);
            this.cbAddCreateDatabase.TabIndex = 52;
            this.cbAddCreateDatabase.Text = "Add CREATE DATABASE statement";
            this.cbAddCreateDatabase.UseVisualStyleBackColor = true;
            // 
            // cbExportTableStructure
            // 
            this.cbExportTableStructure.AutoSize = true;
            this.cbExportTableStructure.Checked = true;
            this.cbExportTableStructure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExportTableStructure.Location = new System.Drawing.Point(6, 52);
            this.cbExportTableStructure.Name = "cbExportTableStructure";
            this.cbExportTableStructure.Size = new System.Drawing.Size(126, 17);
            this.cbExportTableStructure.TabIndex = 45;
            this.cbExportTableStructure.Text = "ExportTableStructure";
            this.cbExportTableStructure.UseVisualStyleBackColor = true;
            // 
            // cbCalculateTotalRowsFromDatabase
            // 
            this.cbCalculateTotalRowsFromDatabase.AutoSize = true;
            this.cbCalculateTotalRowsFromDatabase.Checked = true;
            this.cbCalculateTotalRowsFromDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCalculateTotalRowsFromDatabase.Location = new System.Drawing.Point(6, 98);
            this.cbCalculateTotalRowsFromDatabase.Name = "cbCalculateTotalRowsFromDatabase";
            this.cbCalculateTotalRowsFromDatabase.Size = new System.Drawing.Size(202, 17);
            this.cbCalculateTotalRowsFromDatabase.TabIndex = 51;
            this.cbCalculateTotalRowsFromDatabase.Text = "Calculate Total Rows From Database";
            this.cbCalculateTotalRowsFromDatabase.UseVisualStyleBackColor = true;
            // 
            // cbResetAutoIncrement
            // 
            this.cbResetAutoIncrement.AutoSize = true;
            this.cbResetAutoIncrement.Location = new System.Drawing.Point(6, 121);
            this.cbResetAutoIncrement.Name = "cbResetAutoIncrement";
            this.cbResetAutoIncrement.Size = new System.Drawing.Size(150, 17);
            this.cbResetAutoIncrement.TabIndex = 50;
            this.cbResetAutoIncrement.Text = "Reset Auto Increment to 1";
            this.cbResetAutoIncrement.UseVisualStyleBackColor = true;
            // 
            // cbExportRows
            // 
            this.cbExportRows.AutoSize = true;
            this.cbExportRows.Checked = true;
            this.cbExportRows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExportRows.Location = new System.Drawing.Point(6, 75);
            this.cbExportRows.Name = "cbExportRows";
            this.cbExportRows.Size = new System.Drawing.Size(112, 17);
            this.cbExportRows.TabIndex = 46;
            this.cbExportRows.Text = "Export Data Rows";
            this.cbExportRows.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbCharSet);
            this.tabPage2.Controls.Add(this.cbImAutoCloseConnection);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtTargetDatabase);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtImEncryptKey);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbImAsyn);
            this.tabPage2.Controls.Add(this.cbImIgnoreSqlError);
            this.tabPage2.Controls.Add(this.cbImEnableEncrypt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(629, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Import Informations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbCharSet
            // 
            this.cbCharSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCharSet.FormattingEnabled = true;
            this.cbCharSet.Location = new System.Drawing.Point(389, 56);
            this.cbCharSet.Name = "cbCharSet";
            this.cbCharSet.Size = new System.Drawing.Size(121, 23);
            this.cbCharSet.TabIndex = 66;
            // 
            // cbImAutoCloseConnection
            // 
            this.cbImAutoCloseConnection.AutoSize = true;
            this.cbImAutoCloseConnection.Checked = true;
            this.cbImAutoCloseConnection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbImAutoCloseConnection.Location = new System.Drawing.Point(6, 29);
            this.cbImAutoCloseConnection.Name = "cbImAutoCloseConnection";
            this.cbImAutoCloseConnection.Size = new System.Drawing.Size(134, 17);
            this.cbImAutoCloseConnection.TabIndex = 65;
            this.cbImAutoCloseConnection.Text = "Auto Close Connection";
            this.cbImAutoCloseConnection.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Default Character Set:";
            // 
            // txtTargetDatabase
            // 
            this.txtTargetDatabase.Location = new System.Drawing.Point(389, 29);
            this.txtTargetDatabase.Name = "txtTargetDatabase";
            this.txtTargetDatabase.Size = new System.Drawing.Size(189, 20);
            this.txtTargetDatabase.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Target Database:";
            // 
            // txtImEncryptKey
            // 
            this.txtImEncryptKey.Location = new System.Drawing.Point(95, 97);
            this.txtImEncryptKey.Name = "txtImEncryptKey";
            this.txtImEncryptKey.Size = new System.Drawing.Size(122, 20);
            this.txtImEncryptKey.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Encrypt Key:";
            // 
            // cbImAsyn
            // 
            this.cbImAsyn.AutoSize = true;
            this.cbImAsyn.Checked = true;
            this.cbImAsyn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbImAsyn.Location = new System.Drawing.Point(6, 6);
            this.cbImAsyn.Name = "cbImAsyn";
            this.cbImAsyn.Size = new System.Drawing.Size(123, 17);
            this.cbImAsyn.TabIndex = 60;
            this.cbImAsyn.Text = "Asynchronous Mode";
            this.cbImAsyn.UseVisualStyleBackColor = true;
            // 
            // cbImIgnoreSqlError
            // 
            this.cbImIgnoreSqlError.AutoSize = true;
            this.cbImIgnoreSqlError.Location = new System.Drawing.Point(6, 52);
            this.cbImIgnoreSqlError.Name = "cbImIgnoreSqlError";
            this.cbImIgnoreSqlError.Size = new System.Drawing.Size(119, 17);
            this.cbImIgnoreSqlError.TabIndex = 53;
            this.cbImIgnoreSqlError.Text = "Ignore Error (Import)";
            this.cbImIgnoreSqlError.UseVisualStyleBackColor = true;
            // 
            // cbImEnableEncrypt
            // 
            this.cbImEnableEncrypt.AutoSize = true;
            this.cbImEnableEncrypt.Location = new System.Drawing.Point(6, 75);
            this.cbImEnableEncrypt.Name = "cbImEnableEncrypt";
            this.cbImEnableEncrypt.Size = new System.Drawing.Size(112, 17);
            this.cbImEnableEncrypt.TabIndex = 57;
            this.cbImEnableEncrypt.Text = "Enable Encryption";
            this.cbImEnableEncrypt.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbHashResult);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtHash2);
            this.tabPage3.Controls.Add(this.txtHashFile2);
            this.tabPage3.Controls.Add(this.txtHash1);
            this.tabPage3.Controls.Add(this.txtHashFile1);
            this.tabPage3.Controls.Add(this.btHashFile2);
            this.tabPage3.Controls.Add(this.btHashFile1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(629, 149);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compare Dump Files";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbHashResult
            // 
            this.lbHashResult.AutoSize = true;
            this.lbHashResult.Location = new System.Drawing.Point(108, 123);
            this.lbHashResult.Name = "lbHashResult";
            this.lbHashResult.Size = new System.Drawing.Size(0, 13);
            this.lbHashResult.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Checksum:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Checksum:";
            // 
            // txtHash2
            // 
            this.txtHash2.Location = new System.Drawing.Point(111, 93);
            this.txtHash2.Name = "txtHash2";
            this.txtHash2.Size = new System.Drawing.Size(503, 20);
            this.txtHash2.TabIndex = 5;
            this.txtHash2.TextChanged += new System.EventHandler(this.txtHash2_TextChanged);
            // 
            // txtHashFile2
            // 
            this.txtHashFile2.Location = new System.Drawing.Point(111, 67);
            this.txtHashFile2.Name = "txtHashFile2";
            this.txtHashFile2.Size = new System.Drawing.Size(503, 20);
            this.txtHashFile2.TabIndex = 4;
            this.txtHashFile2.TextChanged += new System.EventHandler(this.txtHashFile2_TextChanged);
            // 
            // txtHash1
            // 
            this.txtHash1.Location = new System.Drawing.Point(111, 41);
            this.txtHash1.Name = "txtHash1";
            this.txtHash1.Size = new System.Drawing.Size(503, 20);
            this.txtHash1.TabIndex = 3;
            this.txtHash1.TextChanged += new System.EventHandler(this.txtHash1_TextChanged);
            // 
            // txtHashFile1
            // 
            this.txtHashFile1.Location = new System.Drawing.Point(111, 15);
            this.txtHashFile1.Name = "txtHashFile1";
            this.txtHashFile1.Size = new System.Drawing.Size(503, 20);
            this.txtHashFile1.TabIndex = 2;
            this.txtHashFile1.TextChanged += new System.EventHandler(this.txtHashFile1_TextChanged);
            // 
            // btHashFile2
            // 
            this.btHashFile2.Location = new System.Drawing.Point(15, 65);
            this.btHashFile2.Name = "btHashFile2";
            this.btHashFile2.Size = new System.Drawing.Size(90, 23);
            this.btHashFile2.TabIndex = 1;
            this.btHashFile2.Text = "Open File 2";
            this.btHashFile2.UseVisualStyleBackColor = true;
            this.btHashFile2.Click += new System.EventHandler(this.btHashFile2_Click);
            // 
            // btHashFile1
            // 
            this.btHashFile1.Location = new System.Drawing.Point(15, 13);
            this.btHashFile1.Name = "btHashFile1";
            this.btHashFile1.Size = new System.Drawing.Size(90, 23);
            this.btHashFile1.TabIndex = 0;
            this.btHashFile1.Text = "Open File 1";
            this.btHashFile1.UseVisualStyleBackColor = true;
            this.btHashFile1.Click += new System.EventHandler(this.btHashFile1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btDeleteAllRows);
            this.panel2.Controls.Add(this.btCancelImport);
            this.panel2.Controls.Add(this.btCancelExport);
            this.panel2.Controls.Add(this.btExport);
            this.panel2.Controls.Add(this.btImport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 69);
            this.panel2.TabIndex = 56;
            // 
            // btDeleteAllRows
            // 
            this.btDeleteAllRows.Location = new System.Drawing.Point(531, 14);
            this.btDeleteAllRows.Name = "btDeleteAllRows";
            this.btDeleteAllRows.Size = new System.Drawing.Size(94, 42);
            this.btDeleteAllRows.TabIndex = 4;
            this.btDeleteAllRows.Text = "Delete All Rows";
            this.btDeleteAllRows.UseVisualStyleBackColor = true;
            this.btDeleteAllRows.Click += new System.EventHandler(this.btDeleteAllRows_Click);
            // 
            // btCancelImport
            // 
            this.btCancelImport.Location = new System.Drawing.Point(411, 14);
            this.btCancelImport.Name = "btCancelImport";
            this.btCancelImport.Size = new System.Drawing.Size(94, 42);
            this.btCancelImport.TabIndex = 3;
            this.btCancelImport.Text = "Cancel Import";
            this.btCancelImport.UseVisualStyleBackColor = true;
            this.btCancelImport.Click += new System.EventHandler(this.btCancelImport_Click);
            // 
            // btCancelExport
            // 
            this.btCancelExport.Location = new System.Drawing.Point(147, 14);
            this.btCancelExport.Name = "btCancelExport";
            this.btCancelExport.Size = new System.Drawing.Size(94, 42);
            this.btCancelExport.TabIndex = 2;
            this.btCancelExport.Text = "Cancel Export";
            this.btCancelExport.UseVisualStyleBackColor = true;
            this.btCancelExport.Click += new System.EventHandler(this.btCancelExport_Click);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(10, 14);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(131, 42);
            this.btExport.TabIndex = 0;
            this.btExport.Text = "Export (Backup)";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(274, 14);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(131, 42);
            this.btImport.TabIndex = 1;
            this.btImport.Text = "Import (Restore)";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // cbZip
            // 
            this.cbZip.AutoSize = true;
            this.cbZip.Location = new System.Drawing.Point(399, 52);
            this.cbZip.Name = "cbZip";
            this.cbZip.Size = new System.Drawing.Size(123, 17);
            this.cbZip.TabIndex = 66;
            this.cbZip.Text = "Compress as Zip File";
            this.cbZip.UseVisualStyleBackColor = true;
            // 
            // frmMainDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMainDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Demo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSQLLength)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAll;
        private System.Windows.Forms.Button btNone;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExpand;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbAddCreateDatabase;
        private System.Windows.Forms.CheckBox cbAsynchronousModeExport;
        private System.Windows.Forms.CheckBox cbExportTableStructure;
        private System.Windows.Forms.CheckBox cbCalculateTotalRowsFromDatabase;
        private System.Windows.Forms.CheckBox cbResetAutoIncrement;
        private System.Windows.Forms.CheckBox cbExportRows;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbImIgnoreSqlError;
        private System.Windows.Forms.TextBox txtEncryptionKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbEnableEncryption;
        private System.Windows.Forms.CheckBox cbExProcedure;
        private System.Windows.Forms.CheckBox cbExViews;
        private System.Windows.Forms.CheckBox cbExFunction;
        private System.Windows.Forms.CheckBox cbExEvent;
        private System.Windows.Forms.CheckBox cbExTrigger;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTargetDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImEncryptKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbImAsyn;
        private System.Windows.Forms.CheckBox cbImEnableEncrypt;
        private System.Windows.Forms.ProgressBar pgGetTotalRows;
        private System.Windows.Forms.Label lbGetTotalRows;
        private System.Windows.Forms.ProgressBar pbRowsTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbPercent;
        private System.Windows.Forms.Label lbRowProgressCurTable;
        private System.Windows.Forms.ProgressBar pbRowsDB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbRowProgressDB;
        private System.Windows.Forms.ProgressBar pbTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCurrentTable;
        private System.Windows.Forms.Label lbTotalTableDB;
        private System.Windows.Forms.Button btCancelExport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCancelImport;
        private System.Windows.Forms.Label lbImportErr;
        private System.Windows.Forms.Label lbTotalBytes;
        private System.Windows.Forms.ProgressBar pbBytes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnSql;
        private System.Windows.Forms.CheckBox cbAutoCloseConnectionExport;
        private System.Windows.Forms.NumericUpDown nmSQLLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbImAutoCloseConnection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbHashResult;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHash2;
        private System.Windows.Forms.TextBox txtHashFile2;
        private System.Windows.Forms.TextBox txtHash1;
        private System.Windows.Forms.TextBox txtHashFile1;
        private System.Windows.Forms.Button btHashFile2;
        private System.Windows.Forms.Button btHashFile1;
        private System.Windows.Forms.CheckBox cbRecordDumpTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btDeleteAllRows;
        private System.Windows.Forms.ComboBox cbCharSet;
        private System.Windows.Forms.CheckBox cbZip;

    }
}