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
    public partial class frmEncrypt : Form
    {
        MySqlBackup mb;

        public frmEncrypt()
        {
            InitializeComponent();
        }

        private void frmEncrypt_Load(object sender, EventArgs e)
        {
            mb = new MySqlBackup();
        }

        private void cmdNewFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = "New Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql";
            if (sf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            txtDestinationFile.Text = sf.FileName;
        }

        private void cmdChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            if (of.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            txtSourceFile.Text = of.FileName;
        }

        private void cmdDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VariableCheck())
                    return;

                mb.DecryptSqlDumpFile(txtSourceFile.Text, txtDestinationFile.Text, txtKey.Text);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmdEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VariableCheck())
                    return;

                mb.EncryptSqlDumpFile(txtSourceFile.Text, txtDestinationFile.Text, txtKey.Text);
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        bool VariableCheck()
        {
            if (txtDestinationFile.Text.Length == 0)
            {
                MessageBox.Show("Destination File is not specify.");
                return false;
            }
            if (txtSourceFile.Text.Length == 0)
            {
                MessageBox.Show("Source File is not specify.");
                return false;
            }
            if (txtKey.Text.Length == 0)
            {
                MessageBox.Show("Key is not specify.");
                return false;
            }
            return true;
        }
    }
}
