using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlBackupDemo
{
    public partial class frmMainDemo : Form
    {
        string constr = "";

        string CurrentTableName = "";
        long TotalRowsInCurrentTable = 0;
        long TotalRowsInAllTables = 0;
        long CurrentRowInCurrentTable = 0;
        long CurrentRowInAllTable = 0;
        int TotalTables = 0;
        int CurrentTableIndex = 0;
        long CurrentByte = 0;
        long TotalBytes = 0;
        int PercentageComplete = 0;
        int PercentageGetTotalRowsCompleted = 0;

        Timer TimerExport;
        Timer TimerImport;
        Timer TimerStopExport;
        Timer TimerStopImport;

        MySqlBackup mb;

        Methods md = new Methods();

        public frmMainDemo(string connectionString)
        {
            constr = connectionString;
            InitializeComponent();
            nmSQLLength.Value = 1024 * 1024;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
            LoadTables();

            cbCharSet.Items.Add("not specify");
            foreach (ImportInformations.CharSet cs in Enum.GetValues(typeof(ImportInformations.CharSet)))
            {
                cbCharSet.Items.Add(cs);
            }
            cbCharSet.SelectedIndex = 0;
        }

        #region Form's Events

        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == colnSelect.Index || e.ColumnIndex == colnTable.Index)
            {
                dataGridView1.Rows[e.RowIndex].Cells[colnSelect.Index].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[colnSelect.Index].Value);
                dataGridView1.EndEdit();
                dataGridView1.ClearSelection();
            }
            else if (e.ColumnIndex == colnSql.Index)
            {
                dataGridView1.BeginEdit(true);
            }
        }

        void LoadTables()
        {
            mb = new MySqlBackup(constr);
            string[] tables = mb.DatabaseInfo.TableNames;
            dataGridView1.Rows.Clear();
            foreach (string s in tables)
            {
                dataGridView1.Rows[dataGridView1.Rows.Add()].Cells[colnTable.Index].Value = s;
            }
            dataGridView1.ClearSelection();
        }

        private void btExpand_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            if (splitContainer1.Panel2Collapsed)
                btExpand.Text = "Return";
            else
                btExpand.Text = "Expand";
        }

        private void btAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                dgvr.Cells[colnSelect.Index].Value = true;
            }
            dataGridView1.ClearSelection();
        }

        private void btNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                dgvr.Cells[colnSelect.Index].Value = false;
            }
            dataGridView1.ClearSelection();
        }

        #endregion

        #region Export

        private void btExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = "test " + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".sql";
            if (sf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            mb = new MySqlBackup(constr);

            mb.ExportInfo.FileName = sf.FileName;
            mb.ExportInfo.RecordDumpTime = cbRecordDumpTime.Checked;
            mb.ExportInfo.AddCreateDatabase = cbAddCreateDatabase.Checked;
            mb.ExportInfo.AsynchronousMode = cbAsynchronousModeExport.Checked;
            mb.ExportInfo.AutoCloseConnection = cbAutoCloseConnectionExport.Checked;
            mb.ExportInfo.CalculateTotalRowsFromDatabase = cbCalculateTotalRowsFromDatabase.Checked;
            mb.ExportInfo.EnableEncryption = cbEnableEncryption.Checked;
            mb.ExportInfo.EncryptionKey = txtEncryptionKey.Text;
            mb.ExportInfo.ExportEvents = cbExEvent.Checked;
            mb.ExportInfo.ExportFunctions = cbExFunction.Checked;
            mb.ExportInfo.ExportRows = cbExportRows.Checked;
            mb.ExportInfo.ExportStoredProcedures = cbExProcedure.Checked;
            mb.ExportInfo.ExportTableStructure = cbExportTableStructure.Checked;
            mb.ExportInfo.ExportTriggers = cbExTrigger.Checked;
            mb.ExportInfo.ExportViews = cbExViews.Checked;
            mb.ExportInfo.ResetAutoIncrement = cbResetAutoIncrement.Checked;
            mb.ExportInfo.MaxSqlLength = (int)nmSQLLength.Value;
            mb.ExportInfo.TableCustomSql = GetTableSql();
            mb.ExportInfo.ZipOutputFile = cbZip.Checked;

            if (cbAsynchronousModeExport.Checked)
            {
                TimerExport = new Timer();
                TimerExport.Interval = 10;
                TimerExport.Tick += new EventHandler(TimerExport_Tick);
                TimerExport.Start();
                TimerStopExport = new Timer();
                TimerStopExport.Interval = 100;
                TimerStopExport.Tick += new EventHandler(TimerStopExport_Tick);

                mb.ExportProgressChanged += new MySqlBackup.exportProgressChange(mb_ExportProgressChanged);
                mb.ExportCompleted += new MySqlBackup.exportComplete(mb_ExportCompleted);
            }

            try
            {
                mb.Export();

                if (!cbAsynchronousModeExport.Checked)
                {
                    ShowExportCompleteMessage(mb.ExportInfo.CompleteArg);
                }
            }
            catch 
            {
                ShowExportCompleteMessage(mb.ExportInfo.CompleteArg);
            }
        }

        void TimerExport_Tick(object sender, EventArgs e)
        {
            if (PercentageGetTotalRowsCompleted == 100)
                lbGetTotalRows.Text = "100%. Total Rows Calculation Completed. Begin backup process...";
            else if (PercentageGetTotalRowsCompleted == 0)
                lbGetTotalRows.Text = "";
            else
                lbGetTotalRows.Text = "Calculating Total Rows... " + PercentageGetTotalRowsCompleted.ToString() + "% completed.";

            pgGetTotalRows.Value = PercentageGetTotalRowsCompleted;

            pbPercent.Value = PercentageComplete;
            lbPercentage.Text = PercentageComplete + "% Completed";

            lbCurrentTable.Text = CurrentTableName;
            lbRowProgressCurTable.Text = CurrentRowInCurrentTable + " / " + TotalRowsInCurrentTable;
            lbRowProgressDB.Text = CurrentRowInAllTable + " / " + TotalRowsInAllTables;
            lbTotalTableDB.Text = CurrentTableIndex + " / " + TotalTables;

            pbTable.Maximum = (int)TotalTables * 10;
            pbTable.Value = (int)CurrentTableIndex * 10;

            if (TotalRowsInAllTables != 0)
            {
                try
                {
                    pbRowsDB.Maximum = (int)TotalRowsInAllTables;
                    pbRowsDB.Value = (int)CurrentRowInAllTable;
                    pbRowsTable.Maximum = (int)TotalRowsInCurrentTable;
                    pbRowsTable.Value = (int)CurrentRowInCurrentTable;
                }
                catch 
                {
                    // Purposely left empty
                    // reason:
                    // pbRowsTable.Maximum might be holding total rows for table1
                    // but value for pbRowsTable.Value might be from table2
                    // if total rows of table1 is 10 and value of current row is 11 in table2
                    // exception will occur because value 11 is exceed maximum of pbRowsTable which is 10.
                    // This is a rare but might possible happened case.
                    // Because of the process is too fast, that the values might not come from the same table.
                    // MySqlBackup.NET has loop to next table
                    // This happens usually when total rows of the previous table is few,
                    // It is fast enough to finish processing and switch to next table almost simultaneously..
                }
            }
        }

        void TimerStopExport_Tick(object sender, EventArgs e)
        {
            TimerStopExport.Stop();
            if (TimerExport != null)
                TimerExport.Stop();
        }

        void mb_ExportCompleted(object sender, ExportCompleteArg e)
        {
            ShowExportCompleteMessage(e);
        }

        void ShowExportCompleteMessage(ExportCompleteArg e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Export " + e.CompletedType.ToString() + "\r\n");
            sb.Append("Time Start: " + e.TimeStart.ToString() + "\r\n");
            sb.Append("Time End: " + e.TimeEnd.ToString() + "\r\n");
            sb.Append("Time Used: " + e.TimeUsed.Minutes + " m " + e.TimeUsed.Seconds + " s " + e.TimeUsed.Milliseconds + " ms\r\n");
            MessageBoxButtons mbb = MessageBoxButtons.YesNo;
            if (e.Error != null)
            {
                sb.Append("\r\nError Message:\r\n\r\n");
                sb.Append(e.Error.ToString());
                mbb = MessageBoxButtons.OK;
            }
            else
            {
                sb.Append("File save at: " + mb.ExportInfo.FileName + "\r\n\r\nDo you want to open the dump file?");
            }
            TimerStopExport.Start();

            if (MessageBox.Show(sb.ToString(), "Finished", mbb) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = mb.ExportInfo.FileName;
                p.Start();
            }
        }

        void mb_ExportProgressChanged(object sender, ExportProgressArg e)
        {
            PercentageGetTotalRowsCompleted = e.PercentageGetTotalRowsCompleted;
            PercentageComplete = e.PercentageCompleted;
            CurrentTableName = e.CurrentTableName;
            TotalRowsInCurrentTable = e.TotalRowsInCurrentTable;
            TotalRowsInAllTables = e.TotalRowsInAllTables;
            CurrentRowInCurrentTable = e.CurrentRowInCurrentTable;
            CurrentRowInAllTable = e.CurrentRowInAllTable;
            TotalTables = e.TotalTables;
            CurrentTableIndex = e.CurrentTableIndex;

            PercentageGetTotalRowsCompleted = e.PercentageGetTotalRowsCompleted;
            PercentageComplete = e.PercentageCompleted;
            CurrentTableName = e.CurrentTableName;
            TotalRowsInCurrentTable = e.TotalRowsInCurrentTable;
            TotalRowsInAllTables = e.TotalRowsInAllTables;
            CurrentRowInCurrentTable = e.CurrentRowInCurrentTable;
            CurrentRowInAllTable = e.CurrentRowInAllTable;
            TotalTables = e.TotalTables;
            CurrentTableIndex = e.CurrentTableIndex;
        }

        Dictionary<string,string> GetTableSql()
        {
            Dictionary<string, string> dicTableSql = new Dictionary<string, string>();
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(dgvr.Cells[colnSelect.Index].Value))
                {
                    string tablename = dgvr.Cells[colnTable.Index].Value+"";
                    string sql = dgvr.Cells[colnSql.Index].Value + "";
                    if (sql == "")
                    {
                        sql = string.Format("SELECT * FROM `{0}`;", tablename);
                    }
                    dicTableSql.Add(tablename, sql);
                }
            }
            if (dicTableSql.Count == 0)
                return null;
            return dicTableSql;
        }

        private void btCancelExport_Click(object sender, EventArgs e)
        {
            mb.CancelExport();
            TimerStopExport.Start();
            if (!mb.ExportInfo.AsynchronousMode)
            {
                MessageBox.Show("Export cancelled.");
            }
        }

        #endregion

        #region Import

        private void btImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            if (of .ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            mb = new MySqlBackup(constr);

            mb.ImportInfo.AsynchronousMode = cbImAsyn.Checked;
            mb.ImportInfo.AutoCloseConnection = cbImAutoCloseConnection.Checked;
            mb.ImportInfo.EnableEncryption = cbImEnableEncrypt.Checked;
            mb.ImportInfo.EncryptionKey = txtImEncryptKey.Text;
            mb.ImportInfo.FileName = of.FileName;
            mb.ImportInfo.IgnoreSqlError = cbImIgnoreSqlError.Checked;
            string newCharSet = "";
            if (cbCharSet.SelectedIndex > 0)
                newCharSet = cbCharSet.Text;

            mb.ImportInfo.SetTargetDatabase(txtTargetDatabase.Text, newCharSet);

            if (cbImAsyn.Checked)
            {
                TimerImport = new Timer();
                TimerImport.Interval = 10;
                TimerImport.Tick += new EventHandler(TimerImport_Tick);
                TimerImport.Start();
                TimerStopImport = new Timer();
                TimerStopImport.Interval = 100;
                TimerStopImport.Tick += new EventHandler(TimerStopImport_Tick);

                mb.ImportProgressChanged += new MySqlBackup.importProgressChange(mb_ImportProgressChanged);
                mb.ImportCompleted += new MySqlBackup.importComplete(mb_ImportCompleted);
            }

            try
            {
                mb.Import();

                if (!cbImAsyn.Checked)
                {
                    ShowImportCompleteMessage(mb.ImportInfo.CompleteArg);
                }
            }
            catch
            {
                ShowImportCompleteMessage(mb.ImportInfo.CompleteArg);
            }
        }

        void mb_ImportCompleted(object sender, ImportCompleteArg e)
        {
            ShowImportCompleteMessage(e);
        }

        void ShowImportCompleteMessage(ImportCompleteArg e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Import " + e.CompletedType.ToString() + "\r\n");
            sb.Append("Start Time: " + e.TimeStart.ToString() + "\r\n");
            sb.Append("End Time: " + e.TimeEnd.ToString() + "\r\n");
            sb.Append("Time Used: " + e.TimeUsed.Minutes + " m " + e.TimeUsed.Seconds + " s " + e.TimeUsed.Milliseconds + " ms\r\n");

            if (e.HasErrors)
            {
                sb.Append("Errors occur during the import process.\r\n\r\nDisplaying the last exception:\r\n\r\n" + e.LastError.ToString());
            }

            MessageBox.Show(sb.ToString());
        }

        void mb_ImportProgressChanged(object sender, ImportProgressArg e)
        {
            PercentageComplete = e.PercentageCompleted;
            TotalBytes = e.TotalBytes;
            CurrentByte = e.CurrentByte;
        }

        void TimerImport_Tick(object sender, EventArgs e)
        {
            lbTotalBytes.Text = "Processed bytes: " + CurrentByte + " / " + TotalBytes;
            pbBytes.Value = PercentageComplete;
        }

        private void btCancelImport_Click(object sender, EventArgs e)
        {
            mb.CancelImport();
            TimerStopImport.Start();
            if (!mb.ImportInfo.AsynchronousMode)
            {
                MessageBox.Show("Import cancelled.");
            }
        }

        void TimerStopImport_Tick(object sender, EventArgs e)
        {
            TimerStopImport.Stop();
            if (TimerImport != null)
                TimerImport.Stop();
        }

        #endregion

        #region Compare File by SHA256
        private void txtHash2_TextChanged(object sender, EventArgs e)
        {
            CompareFilesDisplayResult();
        }

        private void txtHashFile2_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtHashFile2.Text))
            {
                byte[] ba = System.IO.File.ReadAllBytes(txtHashFile2.Text);
                txtHash2.Text = md.Sha2Hash(ba);
            }
        }

        private void txtHashFile1_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtHashFile1.Text))
            {
                byte[] ba = System.IO.File.ReadAllBytes(txtHashFile1.Text);
                txtHash1.Text = md.Sha2Hash(ba);
            }
        }

        private void txtHash1_TextChanged(object sender, EventArgs e)
        {
            CompareFilesDisplayResult();
        }

        private void btHashFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtHashFile1.Text = of.FileName;
            }
        }

        private void btHashFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtHashFile2.Text = of.FileName;
            }
        }

        void CompareFilesDisplayResult()
        {
            if (txtHash1.Text == txtHash2.Text)
            {
                lbHashResult.Text = "Match. The content of these 2 files are totally same.";
            }
            else
            {
                lbHashResult.Text = "Not match. The contents are not totally same. Make sure you have disabled Record Dump Time.";
            }
        }
        #endregion

        private void btDeleteAllRows_Click(object sender, EventArgs e)
        {
            mb = new MySqlBackup(constr);
            mb.DeleteAllRows(true);
            MessageBox.Show("done");
        }

    }
}
