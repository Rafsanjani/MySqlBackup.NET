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
    public partial class frmBLOB : Form
    {
        string constr = "";

        public frmBLOB(string connectionstring)
        {
            InitializeComponent();
            constr = connectionstring;

            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                conn.Open();
                DataTable dt = new DataTable();
                string sql = "show tables;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    cbTable.Items.Add(dr[0] + "");
                }
                conn.Close();
            }
            cbTable.SelectedIndex = -1;
            cbTable.SelectedIndexChanged += new EventHandler(cbTable_SelectedIndexChanged);
        }

        void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                conn.Open();
                DataTable dt = new DataTable();
                string sql = "show columns from `" + cbTable.Text + "`;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
                cbBLOB.Items.Clear();
                cbFileName.Items.Clear();
                cbFileSize.Items.Clear();
                bool hasBLOB = false;
                foreach (DataRow dr in dt.Rows)
                {
                    string colname = dr["Field"] + "";
                    string coltype = dr["Type"] + "";
                    if (coltype.ToLower().Contains("blob"))
                    {
                        cbBLOB.Items.Add(colname);
                        hasBLOB = true;
                    }
                    else
                    {
                        cbFileName.Items.Add(colname);
                        cbFileSize.Items.Add(colname);
                    }
                }
                conn.Close();
                if (hasBLOB)
                    label5.Visible = false;
                else
                    label5.Visible = true;
            }
            try
            {
                cbBLOB.SelectedIndex = 0;
                cbFileName.SelectedIndex = 0;
                cbFileSize.SelectedIndex = 1;
            }
            catch { }
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlBackup mb = new MySql.Data.MySqlClient.MySqlBackup(constr);
                mb.ExportBlobAsFile(txtFolder.Text, cbTable.Text, cbBLOB.Text, cbFileName.Text, cbFileSize.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            MessageBox.Show("Files have exported successfully and saved to\r\n\r\n" + txtFolder.Text);
        }

        private void cmdFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowNewFolderButton = true;
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFolder.Text = f.SelectedPath;
            }
        }
    }
}
