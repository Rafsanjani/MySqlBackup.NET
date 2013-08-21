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
    public partial class frmInsertBlob : Form
    {
        string constr = "";
        public frmInsertBlob(string connectionString)
        {
            constr = connectionString;
            InitializeComponent();

            MySqlBackup mb = new MySqlBackup(connectionString);
            foreach (string s in mb.DatabaseInfo.TableNames)
            {
                cbTable.Items.Add(s);
            }
            cbTable.SelectedIndex = -1;
            this.cbTable.SelectedIndexChanged += new EventHandler(cbTable_SelectedIndexChanged);
        }

        void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hasBLOB = false;
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                conn.Open();
                string sql = "show columns from `" + cbTable.Text + "`;";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
                cbColBLOB.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string s = dr["Type"] + "";
                    if (s.ToLower().Contains("blob"))
                    {
                        hasBLOB = true;
                        cbColBLOB.Items.Add(dr["Field"] + "");
                    }
                    else
                    {
                        cbColFileName.Items.Add(dr["Field"] + "");
                        cbColFileSize.Items.Add(dr["Field"] + "");
                      
                    }
                }

                try
                {
                    cbColBLOB.SelectedIndex = 0;
                    cbColFileSize.SelectedIndex = 1;
                    cbColFileName.SelectedIndex = 0;
                }
                catch { }
                conn.Close();
            }

            if (!hasBLOB)
            {
                MessageBox.Show("This table has no BLOB data type column.");
            }
        }

        private void frmInsertBlob_Load(object sender, EventArgs e)
        {

        }

        private void btFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            if (of.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            txtFile.Text = of.FileName;
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(txtFile.Text))
            {
                MessageBox.Show("The specify file does not exists.");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                Methods md = new  Methods();
                byte[] ba = System.IO.File.ReadAllBytes(txtFile.Text);
                

                for (int i = 0; i < (int)numericUpDown1.Value; i++)
                {
                    string sql = "insert into `" + cbTable.Text + "`(`" + cbColBLOB.Text + "`, `" + cbColFileName.Text + "`,`" + cbColFileSize.Text + "`) values(" + md.GetBLOBSqlDataStringFromBytes(ba) + ",'" + System.IO.Path.GetFileNameWithoutExtension(txtFile.Text) + (i + 1) + System.IO.Path.GetExtension(txtFile.Text) + "'," + ba.Length + ");";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }

                md = null;
                cmd = null;

                conn.Close();
            }
            MessageBox.Show("Done.");
        }
    }
}
