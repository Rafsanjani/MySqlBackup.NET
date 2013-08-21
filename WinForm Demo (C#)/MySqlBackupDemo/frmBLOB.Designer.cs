namespace MySqlBackupDemo
{
    partial class frmBLOB
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdFolder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.cmdExport = new System.Windows.Forms.Button();
            this.cbFileName = new System.Windows.Forms.ComboBox();
            this.cbFileSize = new System.Windows.Forms.ComboBox();
            this.cbBLOB = new System.Windows.Forms.ComboBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Column (File Name):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Column (File Size):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Column (BLOB):";
            // 
            // cmdFolder
            // 
            this.cmdFolder.Image = global::MySqlBackupDemo.Properties.Resources.folder_open_sharp_thick;
            this.cmdFolder.Location = new System.Drawing.Point(290, 184);
            this.cmdFolder.Name = "cmdFolder";
            this.cmdFolder.Size = new System.Drawing.Size(51, 25);
            this.cmdFolder.TabIndex = 37;
            this.cmdFolder.UseVisualStyleBackColor = true;
            this.cmdFolder.Click += new System.EventHandler(this.cmdFolder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Select a folder that the files will save to:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(67, 215);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(379, 21);
            this.txtFolder.TabIndex = 35;
            // 
            // cmdExport
            // 
            this.cmdExport.Location = new System.Drawing.Point(190, 254);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(139, 23);
            this.cmdExport.TabIndex = 38;
            this.cmdExport.Text = "Start Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // cbFileName
            // 
            this.cbFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileName.FormattingEnabled = true;
            this.cbFileName.Location = new System.Drawing.Point(179, 85);
            this.cbFileName.Name = "cbFileName";
            this.cbFileName.Size = new System.Drawing.Size(196, 23);
            this.cbFileName.TabIndex = 2;
            // 
            // cbFileSize
            // 
            this.cbFileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileSize.FormattingEnabled = true;
            this.cbFileSize.Location = new System.Drawing.Point(179, 115);
            this.cbFileSize.Name = "cbFileSize";
            this.cbFileSize.Size = new System.Drawing.Size(196, 23);
            this.cbFileSize.TabIndex = 3;
            // 
            // cbBLOB
            // 
            this.cbBLOB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBLOB.FormattingEnabled = true;
            this.cbBLOB.Location = new System.Drawing.Point(179, 144);
            this.cbBLOB.Name = "cbBLOB";
            this.cbBLOB.Size = new System.Drawing.Size(196, 23);
            this.cbBLOB.TabIndex = 4;
            // 
            // cbTable
            // 
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(179, 22);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(196, 23);
            this.cbTable.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "This table has no BLOB column.";
            this.label5.Visible = false;
            // 
            // frmBLOB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.cbBLOB);
            this.Controls.Add(this.cbFileSize);
            this.Controls.Add(this.cbFileName);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.cmdFolder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBLOB";
            this.Text = "BLOB data Export Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdFolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button cmdExport;
        private System.Windows.Forms.ComboBox cbFileName;
        private System.Windows.Forms.ComboBox cbFileSize;
        private System.Windows.Forms.ComboBox cbBLOB;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label label5;
    }
}