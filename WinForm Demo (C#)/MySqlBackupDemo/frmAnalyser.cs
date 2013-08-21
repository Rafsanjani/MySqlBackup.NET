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
    public partial class frmAnalyser : Form
    {
        int totalSection = 0;
        int error = 0;
        StringBuilder sb;
        BackgroundWorker bw = new BackgroundWorker();
        string connection = "";
        public frmAnalyser(string constr)
        {
            connection = constr;
            InitializeComponent();
            webBrowser1.DocumentText = "<h1>Please database is being analysed...<br />Please wait...</h1>";
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.RunWorkerAsync();
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            webBrowser1.DocumentText = sb.ToString();
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            sb = new StringBuilder();
            sb.Append("<html><head><style>h1 { line-height:160%; font-size: 20pt; } h2 { line-height:160%; font-size: 14pt; } body { font-family: Segoe UI; color: #5C5C5C; line-height: 150%; } table { border: 1px solid #5C5C5C; border-collapse: collapse; } td { font-size: 10pt; padding: 4px; border: 1px solid #5C5C5C; } .code { font-family: Courier New; font-size: 10pt; line-height:110%; } </style></head>");
            sb.Append("<body>");

            DataTable dt = new DataTable();
            string user = "";
            string database = "";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = new MySqlCommand();
                da.SelectCommand.Connection = conn;

                try
                {
                    // Database
                    totalSection++;
                    sb.Append("<h1>Database Analyse Report</h1><hr />");
                    da.SelectCommand.CommandText = "select database();";
                    database = da.SelectCommand.ExecuteScalar() + "";
                    sb.Append("<h2>" + database + "</h2>");
                    da.SelectCommand.CommandText = "show create database `" + database + "`;";
                    dt = new DataTable();
                    da.Fill(dt);
                    sb.Append("<p><span class=\"code\">" + dt.Rows[0][1] + "</span></p>");
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                try
                {
                    // User
                    totalSection++;
                    sb.Append("<h1>User</h1>");
                    da.SelectCommand.CommandText = "select current_user;";
                    user = ((da.SelectCommand.ExecuteScalar() + "").Split('@'))[0];
                    sb.Append("<h2>" + user + "</h2>");
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                try
                {
                    // Global Privileges
                    totalSection++;
                    sb.Append("<h2>Global Privileges</h2>");
                    da.SelectCommand.CommandText = "SELECT  mu.host `Host`,  mu.user `User`,  REPLACE(RTRIM(CONCAT(  IF(mu.Select_priv = 'Y', 'Select ', ''),  IF(mu.Insert_priv = 'Y', 'Insert ', ''),  IF(mu.Update_priv = 'Y', 'Update ', ''),  IF(mu.Delete_priv = 'Y', 'Delete ', ''),  IF(mu.Create_priv = 'Y', 'Create ', ''),  IF(mu.Drop_priv = 'Y', 'Drop ', ''),  IF(mu.Reload_priv = 'Y', 'Reload ', ''),  IF(mu.Shutdown_priv = 'Y', 'Shutdown ', ''),  IF(mu.Process_priv = 'Y', 'Process ', ''),  IF(mu.File_priv = 'Y', 'File ', ''),  IF(mu.Grant_priv = 'Y', 'Grant ', ''),  IF(mu.References_priv = 'Y', 'References ', ''),  IF(mu.Index_priv = 'Y', 'Index ', ''),  IF(mu.Alter_priv = 'Y', 'Alter ', ''),  IF(mu.Show_db_priv = 'Y', 'Show_db ', ''),  IF(mu.Super_priv = 'Y', 'Super ', ''),  IF(mu.Create_tmp_table_priv = 'Y', 'Create_tmp_table ', ''),  IF(mu.Lock_tables_priv = 'Y', 'Lock_tables ', ''),  IF(mu.Execute_priv = 'Y', 'Execute ', ''),  IF(mu.Repl_slave_priv = 'Y', 'Repl_slave ', ''),  IF(mu.Repl_client_priv = 'Y', 'Repl_client ', ''),  IF(mu.Create_view_priv = 'Y', 'Create_view ', ''),  IF(mu.Show_view_priv = 'Y', 'Show_view ', ''),  IF(mu.Create_routine_priv = 'Y', 'Create_routine ', ''),  IF(mu.Alter_routine_priv = 'Y', 'Alter_routine ', ''),  IF(mu.Create_user_priv = 'Y', 'Create_user ', ''),  IF(mu.Event_priv = 'Y', 'Event ', ''),  IF(mu.Trigger_priv = 'Y', 'Trigger ', '')  )), ' ', ', ') AS `Privileges` FROM  mysql.user mu where mu.User = '" + user + "' ORDER BY  mu.Host,  mu.User;";
                    dt = new DataTable();
                    da.Fill(dt);
                    sb.Append(GetTableHtml(dt));
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                try
                {
                    totalSection++;
                // Database Privileges
                sb.Append("<h2>Database Privileges</h2>");
                da.SelectCommand.CommandText = "SELECT  md.host `Host`,  md.user `User`,  md.db `Database`,  REPLACE(RTRIM(CONCAT(  IF(md.Select_priv = 'Y', 'Select ', ''),  IF(md.Insert_priv = 'Y', 'Insert ', ''),  IF(md.Update_priv = 'Y', 'Update ', ''),  IF(md.Delete_priv = 'Y', 'Delete ', ''),  IF(md.Create_priv = 'Y', 'Create ', ''),  IF(md.Drop_priv = 'Y', 'Drop ', ''),  IF(md.Grant_priv = 'Y', 'Grant ', ''),  IF(md.References_priv = 'Y', 'References ', ''),  IF(md.Index_priv = 'Y', 'Index ', ''),  IF(md.Alter_priv = 'Y', 'Alter ', ''),  IF(md.Create_tmp_table_priv = 'Y', 'Create_tmp_table ', ''),  IF(md.Lock_tables_priv = 'Y', 'Lock_tables ', ''),  IF(md.Create_view_priv = 'Y', 'Create_view ', ''),  IF(md.Show_view_priv = 'Y', 'Show_view ', ''),  IF(md.Create_routine_priv = 'Y', 'Create_routine ', ''),  IF(md.Alter_routine_priv = 'Y', 'Alter_routine ', ''),  IF(md.Execute_priv = 'Y', 'Execute ', ''),  IF(md.Event_priv = 'Y', 'Event ', ''),  IF(md.Trigger_priv = 'Y', 'Trigger ', '')  )), ' ', ', ') AS `Privileges` FROM  mysql.db md where md.Db = '" + database + "' ORDER BY  md.Host,  md.User,  md.Db;";
                dt = new DataTable();
                da.Fill(dt);
                sb.Append(GetTableHtml(dt));
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                try
                {
                    totalSection++;
                // Privileges of View
                sb.Append("<h2>Privileges of View</h2>");
                da.SelectCommand.CommandText = "SELECT  mv.host `Host`,  mv.user `User`,  CONCAT(mv.Db, '.', mv.Table_name) `Views`,  REPLACE(mv.Table_priv, ',', ', ') AS `Privileges` FROM  mysql.tables_priv mv WHERE mv.Db = '" + database + "' and mv.Table_name IN  (SELECT  DISTINCT    v.table_name `views`  FROM    information_schema.views AS v  ) ORDER BY  mv.Host,  mv.User,  mv.Db,  mv.Table_name;";
                dt = new DataTable();
                da.Fill(dt);
                sb.Append(GetTableHtml(dt));
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                // Privileges of Procedure
                try
                {
                    totalSection++;
                    sb.Append("<h2>Privileges of Procedure</h2>");
                    da.SelectCommand.CommandText = "SELECT  mp.host `Host`,  mp.user `User`,  CONCAT(mp.Db, '.', mp.Routine_name) `Procedures`,  REPLACE(mp.Proc_priv, ',', ', ') AS `Privileges` FROM  mysql.procs_priv mp WHERE mp.Db = '" + database + "' and mp.Routine_type = 'PROCEDURE' ORDER BY  mp.Host,  mp.User,  mp.Db,  mp.Routine_name;";
                    dt = new DataTable();
                    da.Fill(dt);
                    sb.Append(GetTableHtml(dt));
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                // Privileges of Function
                try
                {
                    totalSection++;
                    sb.Append("<h2>Privileges of Function</h2>");
                    da.SelectCommand.CommandText = "SELECT  mf.host `Host`,  mf.user `User`,  CONCAT(mf.Db, '.', mf.Routine_name) `Procedures`,  REPLACE(mf.Proc_priv, ',', ', ') AS `Privileges` FROM  mysql.procs_priv mf WHERE mf.Db = '" + database + "' and mf.Routine_type = 'FUNCTION' ORDER BY  mf.Host,  mf.User,  mf.Db,  mf.Routine_name;";
                    dt = new DataTable();
                    da.Fill(dt);
                    sb.Append(GetTableHtml(dt));
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                try
                {
                    totalSection++;
                // Get Variables
                da.SelectCommand.CommandText = "show variables;";
                dt = new DataTable();
                da.Fill(dt);
                sb.Append("<h1>Show Variables</h1>");
                sb.Append(GetTableHtml(dt));
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                try
                {
                    totalSection++;
                // Get Tables
                da.SelectCommand.CommandText = "show table status;";
                dt = new DataTable();
                da.Fill(dt);
                sb.Append("<h1>Show Table Status</h1>");
                sb.Append("<p>Note: \"Total Rows\" shown in this table is not accurate.</p>");
                sb.Append(GetTableHtml(dt));
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                DataTable dt2 = new DataTable();

                try
                {
                    totalSection++;
                    // Show Create Tables
                    sb.Append("<h1>Create Table</h1>");
                    foreach (DataRow drDT in dt.Rows)
                    {
                        da.SelectCommand.CommandText = "show create table `" + drDT[0] + "`;";
                        dt2 = new DataTable();
                        da.Fill(dt2);
                        sb.Append("<h2>" + drDT[0] + "</h2>");
                        sb.Append("<span class=\"code\">");
                        sb.Append(GetHtmlString(dt2.Rows[0][1] + ""));
                        sb.Append("</span>");
                    }
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                try
                {
                    totalSection++;
                    // Table Collation

                    sb.Append("<h1>Show Full Columns</h1>");
                    foreach (DataRow drDT in dt.Rows)
                    {
                        da.SelectCommand.CommandText = "show full columns from `" + drDT[0] + "`;";
                        dt2 = new DataTable();
                        da.Fill(dt2);
                        sb.Append("<h2>" + drDT[0] + "</h2>");
                        sb.Append(GetTableHtml(dt2));
                    }
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                // Procedure
                try
                {
                    totalSection++;
                    sb.Append("<h1>Show Procedure Status</h1>");
                    da.SelectCommand.CommandText = "show procedure status where Db = '" + database + "';";
                    dt = new DataTable();
                    da.Fill(dt);
                    sb.Append(GetTableHtml(dt));
                    foreach (DataRow dr in dt.Rows)
                    {
                        da.SelectCommand.CommandText = "show create procedure `" + dr["Name"] + "`;";
                        dt2 = new DataTable();
                        da.Fill(dt2);
                        sb.Append("<p><strong>" + da.SelectCommand.CommandText + "</strong></p>");
                        sb.Append(GetTableHtml(dt2));
                    }
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                // Function
                try
                {
                    totalSection++;
                    sb.Append("<h1>Show Function Status</h1>");
                    da.SelectCommand.CommandText = "show function status where Db = '" + database + "';";
                    dt = new DataTable();
                    da.Fill(dt);
                    sb.Append(GetTableHtml(dt));
                    foreach (DataRow dr in dt.Rows)
                    {
                        da.SelectCommand.CommandText = "show create function `" + dr["Name"] + "`;";
                        dt2 = new DataTable();
                        da.Fill(dt2);
                        sb.Append("<p><strong>" + da.SelectCommand.CommandText + "</strong></p>");
                        sb.Append(GetTableHtml(dt2));
                    }
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                // Triggers
                try
                {
                    totalSection++;
                    sb.Append("<h1>Show  Triggers</h1>");
                    da.SelectCommand.CommandText = "show triggers;";
                    dt = new DataTable();
                    da.Fill(dt);
                    sb.Append(GetTableHtml(dt));
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                // Events
                try
                {
                    totalSection++;
                    sb.Append("<h1>Show Events</h1>");
                    da.SelectCommand.CommandText = "show events;";
                    dt = new DataTable();
                    da.Fill(dt);
                    sb.Append(GetTableHtml(dt));
                    foreach (DataRow dr in dt.Rows)
                    {
                        da.SelectCommand.CommandText = "show create event `" + dr["Name"] + "`;";
                        dt2 = new DataTable();
                        da.Fill(dt2);
                        sb.Append("<p><strong>" + da.SelectCommand.CommandText + "</strong></p>");
                        sb.Append(GetTableHtml(dt2));
                    }
                }
                catch (Exception ex)
                {
                    RecordError(ex);
                }

                conn.Close();
            }

            sb.Append("<br /><br /><hr /><h1>Conclusion of Analysis for Database Backup/Restore Task</h1>");
            sb.Append("<p>Test Result: " + (totalSection - error) + " out of " + totalSection + " tests have passed.</p>");
            if (error == 0)
                sb.Append("<p><strong>A full database backup can be executed.</strong></p>");
            else
                sb.Append("<p><strong>Full backup might not successfully due to user privilege limitations.</strong></p>"); 

            sb.Append("</body>");
            sb.Append("</html>");
        }

        string GetTableHtml(DataTable dt)
        {
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("<table>");
            sb2.Append("<tr>");
            foreach (DataColumn dc in dt.Columns)
            {
                sb2.Append("<td>");
                sb2.Append(GetHtmlString(dc.ColumnName));
                sb2.Append("</td>");
            }
            sb2.Append("</tr>");
            foreach (DataRow dr in dt.Rows)
            {
                sb2.Append("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    sb2.Append("<td>");
                    sb2.Append(GetHtmlString((dr[dc.ColumnName] + "")));
                    sb2.Append("</td>");
                }
                sb2.Append("</tr>");
            }
            sb2.Append("</table>");
            return sb2.ToString();
        }

        string GetHtmlString(string input)
        {
            input = input.Replace("\r\n", "^^^|||").Replace("\n", "^^^|||").Replace("\r", "^^^|||");
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char c in input)
            {
                switch (c)
                {
                    case '&':
                        sb.AppendFormat("&amp;");
                        break;
                    case '"':
                        sb.AppendFormat("&quot;");
                        break;
                    case '\'':
                        sb.AppendFormat("&#39;");
                        break;
                    case '<':
                        sb.AppendFormat("&lt;");
                        break;
                    case '>':
                        sb.AppendFormat("&gt;");
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }
            return sb.ToString().Replace("^^^|||", "<br />");
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "HTML|*.html";
            sf.FileName = "Report.html";
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllText(sf.FileName, webBrowser1.DocumentText, Encoding.UTF8);
                MessageBox.Show("Report exported successfully at:\n" + sf.FileName);
            }
        }

        void RecordError(Exception ex)
        {
            error++;
            sb.Append("<p>" + GetHtmlString(ex.Message) + "</p>");
        }
    }
}
