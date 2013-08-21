using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        MySqlBackup mb;
        int curPercentage;

        public Form1()
        {
            InitializeComponent(); 
            mb = new MySqlBackup();
            mb.ExportProgressChanged += new MySqlBackup.exportProgressChange(mb_ExportProgressChanged);
            mb.ExportCompleted += new MySqlBackup.exportComplete(mb_ExportCompleted);
            mb.ImportProgressChanged += new MySqlBackup.importProgressChange(mb_ImportProgressChanged);
            mb.ImportCompleted += new MySqlBackup.importComplete(mb_ImportCompleted);
        }

        private void btBackup_Click(System.Object sender, System.EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = "test " + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".sql";
            if (sf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            ProgressBar1.Value = 0;
            timerRead.Start();
            mb.Connection = new MySqlConnection(txtConstr.Text);
            mb.ExportInfo.FileName = sf.FileName;
            mb.ExportInfo.AsynchronousMode = true;
            mb.ExportInfo.CalculateTotalRowsFromDatabase = true;
            mb.ExportInfo.ExportTableStructure = true;
            mb.ExportInfo.ExportRows = true;
            mb.Export();

        }

        private void btRestore_Click(System.Object sender, System.EventArgs e)
        {
            OpenFileDialog oof = new OpenFileDialog();
            oof.Multiselect = false;
            if (oof.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            ProgressBar1.Value = 0;
            timerRead.Start();
            mb.Connection = new MySqlConnection(txtConstr.Text);
            mb.ImportInfo.AsynchronousMode = true;
            mb.ImportInfo.FileName = oof.FileName;
            mb.Import();
        }

        private void mb_ExportCompleted(object sender, ExportCompleteArg e)
        {
            timerStop.Start();
            string errMsg = null;
            if (e.Error != null)
            {
                errMsg = e.Error.ToString();
            }
            else
            {
                errMsg = "";
            }
            MessageBox.Show("Export " + e.CompletedType.ToString() + Environment.NewLine + errMsg);
        }

        private void mb_ImportCompleted(object sender, ImportCompleteArg e)
        {
            timerStop.Start();
            string errMsg = null;
            if (e.LastError != null)
            {
                errMsg = e.LastError.ToString();
            }
            else
            {
                errMsg = "";
            }
            MessageBox.Show("Import " + e.CompletedType.ToString() + Environment.NewLine + errMsg);
        }

        private void mb_ImportProgressChanged(object sender, ImportProgressArg e)
        {
            curPercentage = e.PercentageCompleted;
        }

        private void mb_ExportProgressChanged(object sender, ExportProgressArg e)
        {
            curPercentage = e.PercentageCompleted;
        }

        private void timerRead_Tick(System.Object sender, System.EventArgs e)
        {
            ProgressBar1.Value = curPercentage;
            lb_Progress.Text = "Progress " + curPercentage.ToString() + "%";
        }

        private void timerStop_Tick(System.Object sender, System.EventArgs e)
        {
            timerRead.Stop();
            timerStop.Stop();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            mb.CancelExport();
            mb.CancelImport();
        }

    }
}
