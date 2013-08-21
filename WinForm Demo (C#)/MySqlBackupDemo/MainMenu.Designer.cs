namespace MySqlBackupDemo
{
    partial class MainMenu
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
            this.cmdBLOB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmdEncryptionDemo = new System.Windows.Forms.Button();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btMainDemo = new System.Windows.Forms.Button();
            this.btTestTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btCharSet = new System.Windows.Forms.Button();
            this.btInserBLOB = new System.Windows.Forms.Button();
            this.btSqlExecute = new System.Windows.Forms.Button();
            this.btAnalyser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdBLOB
            // 
            this.cmdBLOB.Location = new System.Drawing.Point(220, 122);
            this.cmdBLOB.Name = "cmdBLOB";
            this.cmdBLOB.Size = new System.Drawing.Size(194, 23);
            this.cmdBLOB.TabIndex = 2;
            this.cmdBLOB.Text = "BLOB Data Export Demo";
            this.cmdBLOB.UseVisualStyleBackColor = true;
            this.cmdBLOB.Click += new System.EventHandler(this.cmdBLOB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MySQL Connection String:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(622, 20);
            this.textBox1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(296, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Remember, so that I won\'t have to type it again next time.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmdEncryptionDemo
            // 
            this.cmdEncryptionDemo.Location = new System.Drawing.Point(220, 151);
            this.cmdEncryptionDemo.Name = "cmdEncryptionDemo";
            this.cmdEncryptionDemo.Size = new System.Drawing.Size(194, 23);
            this.cmdEncryptionDemo.TabIndex = 3;
            this.cmdEncryptionDemo.Text = "SQL Dump File Encryption Demo";
            this.cmdEncryptionDemo.UseVisualStyleBackColor = true;
            this.cmdEncryptionDemo.Click += new System.EventHandler(this.cmdEncryptionDemo_Click);
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(248, 392);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(61, 13);
            this.lbVersion.TabIndex = 8;
            this.lbVersion.Text = "version info";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMainDemo
            // 
            this.btMainDemo.Location = new System.Drawing.Point(220, 93);
            this.btMainDemo.Name = "btMainDemo";
            this.btMainDemo.Size = new System.Drawing.Size(194, 23);
            this.btMainDemo.TabIndex = 1;
            this.btMainDemo.Text = "Main Demo";
            this.btMainDemo.UseVisualStyleBackColor = true;
            this.btMainDemo.Click += new System.EventHandler(this.btMainDemo_click);
            // 
            // btTestTable
            // 
            this.btTestTable.Location = new System.Drawing.Point(18, 28);
            this.btTestTable.Name = "btTestTable";
            this.btTestTable.Size = new System.Drawing.Size(194, 23);
            this.btTestTable.TabIndex = 4;
            this.btTestTable.Text = "Sample Data Generator";
            this.btTestTable.UseVisualStyleBackColor = true;
            this.btTestTable.Click += new System.EventHandler(this.btTestTable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Below are some of the Tools that help to Develop MySqlBackup.NET\r\n(not part of My" +
    "SqlBackup.NET)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCharSet
            // 
            this.btCharSet.Location = new System.Drawing.Point(18, 57);
            this.btCharSet.Name = "btCharSet";
            this.btCharSet.Size = new System.Drawing.Size(194, 23);
            this.btCharSet.TabIndex = 10;
            this.btCharSet.Text = "Environment Character Set";
            this.btCharSet.UseVisualStyleBackColor = true;
            this.btCharSet.Click += new System.EventHandler(this.btCharSet_Click);
            // 
            // btInserBLOB
            // 
            this.btInserBLOB.Location = new System.Drawing.Point(242, 57);
            this.btInserBLOB.Name = "btInserBLOB";
            this.btInserBLOB.Size = new System.Drawing.Size(194, 23);
            this.btInserBLOB.TabIndex = 11;
            this.btInserBLOB.Text = "Insert File as BLOB into Database";
            this.btInserBLOB.UseVisualStyleBackColor = true;
            this.btInserBLOB.Click += new System.EventHandler(this.btInserBLOB_Click);
            // 
            // btSqlExecute
            // 
            this.btSqlExecute.Location = new System.Drawing.Point(242, 28);
            this.btSqlExecute.Name = "btSqlExecute";
            this.btSqlExecute.Size = new System.Drawing.Size(194, 23);
            this.btSqlExecute.TabIndex = 12;
            this.btSqlExecute.Text = "SQL Statements Execution";
            this.btSqlExecute.UseVisualStyleBackColor = true;
            this.btSqlExecute.Click += new System.EventHandler(this.btSqlExecute_Click);
            // 
            // btAnalyser
            // 
            this.btAnalyser.Location = new System.Drawing.Point(132, 100);
            this.btAnalyser.Name = "btAnalyser";
            this.btAnalyser.Size = new System.Drawing.Size(194, 23);
            this.btAnalyser.TabIndex = 14;
            this.btAnalyser.Text = "Database Analyser";
            this.btAnalyser.UseVisualStyleBackColor = true;
            this.btAnalyser.Click += new System.EventHandler(this.btAnalyser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTestTable);
            this.groupBox1.Controls.Add(this.btAnalyser);
            this.groupBox1.Controls.Add(this.btCharSet);
            this.groupBox1.Controls.Add(this.btSqlExecute);
            this.groupBox1.Controls.Add(this.btInserBLOB);
            this.groupBox1.Location = new System.Drawing.Point(95, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 134);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMainDemo);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.cmdEncryptionDemo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdBLOB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySqlBackup.NET WinForm Demo 3.3 & Diagnosis Tools";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBLOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button cmdEncryptionDemo;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btMainDemo;
        private System.Windows.Forms.Button btTestTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCharSet;
        private System.Windows.Forms.Button btInserBLOB;
        private System.Windows.Forms.Button btSqlExecute;
        private System.Windows.Forms.Button btAnalyser;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}