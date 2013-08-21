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
    public partial class frmCustomSql : Form
    {
        string constr = "";

        public frmCustomSql(string connectionString)
        {
            constr = connectionString;
            InitializeComponent();
        }

        private void btExecute1_Click(object sender, EventArgs e)
        {
            string a = txt1.Text.ToLower();
            foreach (string s in GetReturnResultQueryStatement())
            {
                if (a.StartsWith(s))
                {
                    Select(txt1.Text);
                    return;
                }
            }
            Execute(txt1.Text);
        }

        private void btExecute2_Click(object sender, EventArgs e)
        {
            string a = txt2.Text.ToLower();
            foreach (string s in GetReturnResultQueryStatement())
            {
                if (a.StartsWith(s))
                {
                    Select(txt2.Text);
                    return;
                }
            }
            Execute(txt2.Text);
        }

        private void btExecute3_Click(object sender, EventArgs e)
        {
            string a = txt3.Text.ToLower();
            foreach (string s in GetReturnResultQueryStatement())
            {
                if (a.StartsWith(s))
                {
                    Select(txt3.Text);
                    return;
                }
            }
            Execute(txt3.Text);
        }

        void Execute(string input)
        {
            try
            {
                int i = 0;
                using (MySqlConnection conn = new MySqlConnection(constr))
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = input;
                    i = cmd.ExecuteNonQuery();

                    conn.Close();
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("Rows affected");
                string s = "";
                if (i > 1)
                    s = "s";
                dt.Rows.Add(i + " row" + s + " affected by the last command. No resultset returned.");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                AutoResize();
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        void Select(string input)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(constr))
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = input;

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    
                    da.Fill(dt);

                    conn.Close();
                }

                DataTable dt2 = new DataTable();
                foreach (DataColumn dc in dt.Columns)
                {
                    dt2.Columns.Add(dc.ColumnName);
                }
                int c = -1;
                foreach (DataRow dr in dt.Rows)
                {
                    c++;
                    dt2.Rows.Add();
                    foreach (DataColumn dc in dt.Columns)
                    {
                        string data = "";
                        if (dr[dc.ColumnName].GetType() == typeof(System.DateTime))
                            data = ((DateTime)dr[dc.ColumnName]).ToString("yyyy-MM-dd HH:mm:ss");
                        else if (dr[dc.ColumnName].GetType() == typeof(MySql.Data.Types.MySqlDateTime))
                            data = ((MySql.Data.Types.MySqlDateTime)dr[dc.ColumnName]).Value.ToString("yyyy-MM-dd HH:mm:ss");
                        else if (dr[dc.ColumnName].GetType() == typeof(byte[]))
                            data = "System.Byte[" + ((byte[])dr[dc.ColumnName]).Length + "]";
                        else
                            data = dr[dc.ColumnName] + "";
                        dt2.Rows[c][dc.ColumnName] = data;
                    }
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt2;

                AutoResize();
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        string[] GetReturnResultQueryStatement()
        {
            string[] sa = textBox1.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sa.Length; i++)
            {
                sa[i] = sa[i].ToLower().Trim();
            }
            return sa;
        }

        void ShowException(Exception ex)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Error");
            dt.Rows.Add(ex.Message);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            AutoResize();
        }
        
        void AutoResize()
        {
            foreach (DataGridViewColumn dc in dataGridView1.Columns)
            {
                dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string a = ((TextBox)sender).Text.ToLower();
                foreach (string s in GetReturnResultQueryStatement())
                {
                    if (a.StartsWith(s))
                    {
                        Select(((TextBox)sender).Text);
                        e.Handled = true;
                        return;
                    }
                }
                Execute(((TextBox)sender).Text);
                e.Handled = true;
            }
        }
    }
}
