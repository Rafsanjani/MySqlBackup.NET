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
    public partial class frmCharSet : Form
    {
        public frmCharSet(string connectionString)
        {
            InitializeComponent();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SHOW VARIABLES LIKE 'character_set\\_%';";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql,conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                DataTable dt2 = new DataTable();
                sql = "SHOW TABLE STATUS;";
                da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt2);

                DataTable dt3 = new DataTable();
                dt3.Columns.Add("Table");
                dt3.Columns.Add("Collation");

                foreach (DataRow dr in dt2.Rows)
                {
                    if (dr["Engine"] + "" != "")
                    {
                        dt3.Rows.Add(dr["Name"] + "", dr["Collation"] + "");
                    }
                }
                dataGridView2.DataSource = dt3;
                conn.Close();
            }

            foreach (DataGridViewColumn dc in dataGridView1.Columns)
            {
                dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            foreach (DataGridViewColumn dc in dataGridView2.Columns)
            {
                dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView2.DefaultCellStyle = dataGridView1.DefaultCellStyle;
        }
    }
}
