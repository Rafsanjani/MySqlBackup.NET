namespace MySqlBackupDemo
{
    partial class frmInsertBlob
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
            this.btFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbColBLOB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbColFileName = new System.Windows.Forms.ComboBox();
            this.cbColFileSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(12, 12);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(75, 23);
            this.btFile.TabIndex = 0;
            this.btFile.Text = "Select a File";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(93, 14);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(400, 20);
            this.txtFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Table:";
            // 
            // cbTable
            // 
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(178, 54);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(280, 21);
            this.cbTable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select the BLOB column:";
            // 
            // cbColBLOB
            // 
            this.cbColBLOB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColBLOB.FormattingEnabled = true;
            this.cbColBLOB.Location = new System.Drawing.Point(178, 81);
            this.cbColBLOB.Name = "cbColBLOB";
            this.cbColBLOB.Size = new System.Drawing.Size(280, 21);
            this.cbColBLOB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "No. of Inserts:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(244, 198);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(191, 258);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(132, 31);
            this.btInsert.TabIndex = 8;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select the File Name Column:";
            // 
            // cbColFileName
            // 
            this.cbColFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColFileName.FormattingEnabled = true;
            this.cbColFileName.Location = new System.Drawing.Point(178, 108);
            this.cbColFileName.Name = "cbColFileName";
            this.cbColFileName.Size = new System.Drawing.Size(280, 21);
            this.cbColFileName.TabIndex = 10;
            // 
            // cbColFileSize
            // 
            this.cbColFileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColFileSize.FormattingEnabled = true;
            this.cbColFileSize.Location = new System.Drawing.Point(178, 135);
            this.cbColFileSize.Name = "cbColFileSize";
            this.cbColFileSize.Size = new System.Drawing.Size(280, 21);
            this.cbColFileSize.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Select the File Size Column:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filename will be auto-incremented.";
            // 
            // frmInsertBlob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 310);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbColFileSize);
            this.Controls.Add(this.cbColFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbColBLOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btFile);
            this.Name = "frmInsertBlob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert File as BLOB into Database";
            this.Load += new System.EventHandler(this.frmInsertBlob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbColBLOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbColFileName;
        private System.Windows.Forms.ComboBox cbColFileSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}