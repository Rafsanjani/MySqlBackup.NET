namespace MySqlBackupDemo
{
    partial class frmSampleData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSampleData));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmTableNo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nmRowsNumber = new System.Windows.Forms.NumericUpDown();
            this.btView = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbProgress = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbfix = new System.Windows.Forms.RadioButton();
            this.btRoutine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmTableNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRowsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(88, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(413, 232);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Test Table to be created:";
            // 
            // nmTableNo
            // 
            this.nmTableNo.Location = new System.Drawing.Point(322, 11);
            this.nmTableNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmTableNo.Name = "nmTableNo";
            this.nmTableNo.Size = new System.Drawing.Size(45, 20);
            this.nmTableNo.TabIndex = 3;
            this.nmTableNo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prefix Table Name:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(241, 37);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(59, 20);
            this.txtPrefix.TabIndex = 5;
            this.txtPrefix.Text = "testtable";
            this.txtPrefix.TextChanged += new System.EventHandler(this.txtPrefix_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(12, 345);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(202, 23);
            this.btInsert.TabIndex = 7;
            this.btInsert.Text = "Insert Sample Data Into Test Table";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of Rows to be Inserted into Each Table:";
            // 
            // nmRowsNumber
            // 
            this.nmRowsNumber.Location = new System.Drawing.Point(461, 348);
            this.nmRowsNumber.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmRowsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRowsNumber.Name = "nmRowsNumber";
            this.nmRowsNumber.Size = new System.Drawing.Size(116, 20);
            this.nmRowsNumber.TabIndex = 9;
            this.nmRowsNumber.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(12, 414);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(167, 23);
            this.btView.TabIndex = 10;
            this.btView.Text = "View Random Sample Data:";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(12, 450);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(565, 150);
            this.textBox3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CREATE TABLE `XXX`";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 374);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(202, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(220, 380);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(0, 13);
            this.lbProgress.TabIndex = 14;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(461, 374);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(116, 23);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Cancel Insert";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "(Table will be created automatically if not exists.)";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(323, 328);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.Text = "Random Data";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbfix
            // 
            this.rbfix.AutoSize = true;
            this.rbfix.Checked = true;
            this.rbfix.Location = new System.Drawing.Point(253, 328);
            this.rbfix.Name = "rbfix";
            this.rbfix.Size = new System.Drawing.Size(64, 17);
            this.rbfix.TabIndex = 18;
            this.rbfix.TabStop = true;
            this.rbfix.Text = "Fix Data";
            this.rbfix.UseVisualStyleBackColor = true;
            // 
            // btRoutine
            // 
            this.btRoutine.Location = new System.Drawing.Point(371, 403);
            this.btRoutine.Name = "btRoutine";
            this.btRoutine.Size = new System.Drawing.Size(206, 41);
            this.btRoutine.TabIndex = 19;
            this.btRoutine.Text = "Insert Sample Procedure, Function, Event, Trigger, View";
            this.btRoutine.UseVisualStyleBackColor = true;
            this.btRoutine.Click += new System.EventHandler(this.btRoutine_Click);
            // 
            // frmSampleData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 612);
            this.Controls.Add(this.btRoutine);
            this.Controls.Add(this.rbfix);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.nmRowsNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmTableNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmSampleData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Data Generator";
            ((System.ComponentModel.ISupportInitialize)(this.nmTableNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRowsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmTableNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmRowsNumber;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbfix;
        private System.Windows.Forms.Button btRoutine;
    }
}