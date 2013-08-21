namespace WindowsFormsApplication1
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
            this.txtConstr = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btBackup = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.timerStop = new System.Windows.Forms.Timer(this.components);
            this.lb_Progress = new System.Windows.Forms.Label();
            this.btRestore = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConstr
            // 
            this.txtConstr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConstr.Location = new System.Drawing.Point(14, 33);
            this.txtConstr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConstr.Name = "txtConstr";
            this.txtConstr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConstr.Size = new System.Drawing.Size(550, 25);
            this.txtConstr.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(156, 17);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "MySQL Connection String";
            // 
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(14, 66);
            this.btBackup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(87, 30);
            this.btBackup.TabIndex = 2;
            this.btBackup.Text = "Backup";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar1.Location = new System.Drawing.Point(14, 132);
            this.ProgressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(550, 27);
            this.ProgressBar1.TabIndex = 3;
            // 
            // timerRead
            // 
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // timerStop
            // 
            this.timerStop.Interval = 200;
            this.timerStop.Tick += new System.EventHandler(this.timerStop_Tick);
            // 
            // lb_Progress
            // 
            this.lb_Progress.AutoSize = true;
            this.lb_Progress.Location = new System.Drawing.Point(14, 111);
            this.lb_Progress.Name = "lb_Progress";
            this.lb_Progress.Size = new System.Drawing.Size(63, 17);
            this.lb_Progress.TabIndex = 4;
            this.lb_Progress.Text = "Progress:";
            // 
            // btRestore
            // 
            this.btRestore.Location = new System.Drawing.Point(108, 66);
            this.btRestore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(87, 30);
            this.btRestore.TabIndex = 5;
            this.btRestore.Text = "Restore";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(201, 66);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(87, 30);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 179);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btRestore);
            this.Controls.Add(this.lb_Progress);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtConstr);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "MySqlBackup.NET - Simple Example in C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtConstr;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Timer timerRead;
        private System.Windows.Forms.Timer timerStop;
        private System.Windows.Forms.Label lb_Progress;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.Button btCancel;
        #endregion
    }
}