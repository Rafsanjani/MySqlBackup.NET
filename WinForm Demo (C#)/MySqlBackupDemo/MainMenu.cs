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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            lbVersion.Text = "WinForm Demo 3.3" + Environment.NewLine + "MySqlBackup.NET " + MySqlBackup.Version;
            GetParam();
        }

        #region Remember Connection String
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\constr.txt";
            if (!checkBox1.Checked)
            {
                try
                {
                    System.IO.File.Delete(file);
                }
                catch
                { }
            }
        }

        void RememberConnectionString()
        {
            if (checkBox1.Checked)
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "\\constr.txt", textBox1.Text);
            }
        }

        void GetParam()
        {
            string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\constr.txt";
            if (System.IO.File.Exists(file))
            {
                textBox1.Text = System.IO.File.ReadAllText(file);
                checkBox1.Checked = true;
            }
        }
        #endregion

        bool TestConnection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(textBox1.Text);
                conn.Open();
                conn.Close();
                RememberConnectionString();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void btMainDemo_click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                frmMainDemo f = new frmMainDemo(textBox1.Text);
                f.Show();
            }
        }

        private void btTestTable_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                frmSampleData f = new frmSampleData(textBox1.Text);
                f.Show();
            }
        }

        private void cmdBLOB_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                frmBLOB f = new frmBLOB(textBox1.Text);
                f.Show();
            }
        }

        private void cmdEncryptionDemo_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                frmEncrypt f = new frmEncrypt();
                f.Show();
            }
        }

        private void btCharSet_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                frmCharSet f = new frmCharSet(textBox1.Text);
                f.Show();
            }
        }

        private void btInserBLOB_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                frmInsertBlob f = new frmInsertBlob(textBox1.Text);
                f.Show();
            }
        }

        private void btSqlExecute_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                frmCustomSql f = new frmCustomSql(textBox1.Text);
                f.Show();
            }
        }

        private void btAnalyser_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                frmAnalyser f = new frmAnalyser(textBox1.Text);
                f.Show();
            }
        }
    }
}
