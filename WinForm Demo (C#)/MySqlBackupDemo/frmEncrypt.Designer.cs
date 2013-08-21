namespace MySqlBackupDemo
{
    partial class frmEncrypt
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
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.cmdChooseFile = new System.Windows.Forms.Button();
            this.cmdNewFile = new System.Windows.Forms.Button();
            this.txtDestinationFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdEncrypt = new System.Windows.Forms.Button();
            this.cmdDecrypt = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source File:";
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(107, 44);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(487, 20);
            this.txtSourceFile.TabIndex = 1;
            // 
            // cmdChooseFile
            // 
            this.cmdChooseFile.Location = new System.Drawing.Point(20, 42);
            this.cmdChooseFile.Name = "cmdChooseFile";
            this.cmdChooseFile.Size = new System.Drawing.Size(75, 23);
            this.cmdChooseFile.TabIndex = 2;
            this.cmdChooseFile.Text = "Choose File";
            this.cmdChooseFile.UseVisualStyleBackColor = true;
            this.cmdChooseFile.Click += new System.EventHandler(this.cmdChooseFile_Click);
            // 
            // cmdNewFile
            // 
            this.cmdNewFile.Location = new System.Drawing.Point(20, 102);
            this.cmdNewFile.Name = "cmdNewFile";
            this.cmdNewFile.Size = new System.Drawing.Size(75, 23);
            this.cmdNewFile.TabIndex = 3;
            this.cmdNewFile.Text = "New File";
            this.cmdNewFile.UseVisualStyleBackColor = true;
            this.cmdNewFile.Click += new System.EventHandler(this.cmdNewFile_Click);
            // 
            // txtDestinationFile
            // 
            this.txtDestinationFile.Location = new System.Drawing.Point(107, 104);
            this.txtDestinationFile.Name = "txtDestinationFile";
            this.txtDestinationFile.Size = new System.Drawing.Size(487, 20);
            this.txtDestinationFile.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination File:";
            // 
            // cmdEncrypt
            // 
            this.cmdEncrypt.Location = new System.Drawing.Point(217, 210);
            this.cmdEncrypt.Name = "cmdEncrypt";
            this.cmdEncrypt.Size = new System.Drawing.Size(93, 27);
            this.cmdEncrypt.TabIndex = 6;
            this.cmdEncrypt.Text = "Encrypt File";
            this.cmdEncrypt.UseVisualStyleBackColor = true;
            this.cmdEncrypt.Click += new System.EventHandler(this.cmdEncrypt_Click);
            // 
            // cmdDecrypt
            // 
            this.cmdDecrypt.Location = new System.Drawing.Point(330, 210);
            this.cmdDecrypt.Name = "cmdDecrypt";
            this.cmdDecrypt.Size = new System.Drawing.Size(93, 27);
            this.cmdDecrypt.TabIndex = 7;
            this.cmdDecrypt.Text = "Decrypt File";
            this.cmdDecrypt.UseVisualStyleBackColor = true;
            this.cmdDecrypt.Click += new System.EventHandler(this.cmdDecrypt_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(213, 163);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(218, 20);
            this.txtKey.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Key:";
            // 
            // frmEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 263);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdDecrypt);
            this.Controls.Add(this.cmdEncrypt);
            this.Controls.Add(this.txtDestinationFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdNewFile);
            this.Controls.Add(this.cmdChooseFile);
            this.Controls.Add(this.txtSourceFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEncrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Dump File Encryption Demo";
            this.Load += new System.EventHandler(this.frmEncrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button cmdChooseFile;
        private System.Windows.Forms.Button cmdNewFile;
        private System.Windows.Forms.TextBox txtDestinationFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdEncrypt;
        private System.Windows.Forms.Button cmdDecrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
    }
}