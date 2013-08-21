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
    public partial class frmSampleData : Form
    {
        Random rd = new Random();
        Methods m = new Methods();
        string constr = "";

        bool error = false;

        Timer timerStart;
        Timer timerStop;

        int curRow = 0;
        int curTable = 0;
        string curtablename = "";
        bool cancelProcess = false;
        BackgroundWorker bw;

        string data = "";

        public frmSampleData(string connectionString)
        {
            constr = connectionString;
            InitializeComponent();
            txtPrefix.Text = "";
            txtPrefix.Text = "testtable";
        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {
            label3.Text = string.Format("{0}1, {0}2, {0}3...", txtPrefix.Text.Trim());
            label5.Text = "CREATE TABLE IF NOT EXISTS `" + txtPrefix.Text.Trim() + "1`";
        }

        private void btView_Click(object sender, EventArgs e)
        {
            textBox3.Text =  NewHeader(1) + GetRandomData();
        }

        string GetRandomData()
        {
            if (rbfix.Checked)
            {
                if (data != "")
                    return data;
            }

            byte[] ba = new byte[16];

            rd.NextBytes(ba);
            Guid guid = new Guid(ba);

            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            sb.Append(string.Format("'{0}',", m.RandomString(50)));
            sb.Append(string.Format("{0},", m.random.Next(9000, 100000000)));
            sb.Append(string.Format("{0},", m.random.NextDouble()));
            sb.Append(string.Format("{0},", m.random.NextDouble()));
            sb.Append(string.Format("{0},", m.random.Next(1, 9999)));
            sb.Append(string.Format("'{0}',", m.RandomString(50)));
            sb.Append(string.Format("'{0}',", DateTime.Now.AddDays(m.random.Next(1, 100)).ToString("yyyy-MM-dd HH:mm:ss")));
            sb.Append(string.Format("'{0}',", DateTime.Now.AddDays(m.random.Next(1, 100)).ToString("yyyy-MM-dd")));
            sb.Append(string.Format("'{0}',", DateTime.Now.AddDays(m.random.Next(1, 100)).ToString("HH:mm:ss")));
            sb.Append(string.Format("{0},", m.random.Next(1, 200)));
            sb.Append(string.Format("{0},", m.random.Next(1, 10000) + "." + m.random.Next(1, 99)));
            sb.Append("CURRENT_TIMESTAMP,");
            sb.Append(string.Format("'{0}',", guid.ToString()));
            sb.Append(string.Format(m.GetBLOBSqlDataStringFromBytes(guid.ToByteArray()) + ")"));

            data = sb.ToString();

            return data;
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            curRow = 1;
            error = false;
            timerStart = new Timer();
            timerStart.Interval = 10;
            timerStart.Tick += new EventHandler(timerStart_Tick);

            timerStop = new Timer();
            timerStop.Interval = 300;
            timerStop.Tick+=new EventHandler(timerStop_Tick);

            progressBar1.Maximum = (int)nmRowsNumber.Value;

            bw = new BackgroundWorker();
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            timerStart.Start();
            cancelProcess = false;
            bw.RunWorkerAsync();
        }

        void timerStart_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = curRow;
            lbProgress.Text = curtablename + "   " + curRow + "   " + curTable + " / " + nmTableNo.Value;
        }

        void timerStop_Tick(object sender, EventArgs e)
        {
            timerStop.Stop();
            timerStart.Stop();
            if (!cancelProcess && !error)
                MessageBox.Show("done.");
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timerStop.Start();
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            string datastr = "";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        for (int i = 0; i < (int)nmTableNo.Value; i++)
                        {
                            cmd.CommandText = "CREATE TABLE IF NOT EXISTS `" + txtPrefix.Text.Trim() + (i + 1) + "`" + textBox1.Text;
                            cmd.ExecuteNonQuery();

                            curtablename = txtPrefix.Text.Trim() + (i + 1);
                            curTable = i + 1;
                            int combineCount = 0;
                            StringBuilder sb = new StringBuilder();
                            sb.Append(NewHeader(i + 1) + GetRandomData());
                            for (int j = 1; j < (int)nmRowsNumber.Value; j++)
                            {
                                if (cancelProcess)
                                {
                                    e.Cancel = true;
                                    return;
                                }
                                curRow = j + 1;
                                combineCount++;
                                if (combineCount > 500)
                                {
                                    datastr = sb.ToString();
                                    cmd.CommandText = datastr;
                                    cmd.ExecuteNonQuery();
                                    if (!rbfix.Checked)
                                    {
                                        datastr = "";
                                    }
                                    combineCount = 1;
                                    sb = new StringBuilder();
                                    sb.Append(NewHeader(i + 1) + GetRandomData());
                                    continue;
                                }
                                else
                                {
                                    if (rbfix.Checked && datastr == "")
                                    {
                                        sb.Append(",");
                                        sb.Append(GetRandomData());
                                    }
                                    else if (!rbfix.Checked)
                                    {
                                        sb.Append(",");
                                        sb.Append(GetRandomData());
                                    }
                                }
                                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `" + txtPrefix.Text.Trim() + (i + 1) + "`" + textBox1.Text;
                                cmd.ExecuteNonQuery();
                            }
                            cmd.CommandText = sb.ToString() + ";";
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                error = true;
                timerStart.Stop();
                MessageBox.Show(ex.ToString());
            }
        }

        string NewHeader(int count)
        {
            string a = "INSERT INTO `" + txtPrefix.Text.Trim() + count + "`(`varchar`,`int`,`double`,`float`,`smallint`,`text`,`datetime`,`date`,`time`,`tinyint`,`decimal`,`timestamp`,`char`,`binary`)values";
            return a;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            cancelProcess = true;
            MessageBox.Show("Insert Process Cancelled.");
        }

        private void btRoutine_Click(object sender, EventArgs e)
        {
            string procedure = "DELIMITER |\r\nCREATE PROCEDURE `B`()\r\nDETERMINISTIC\r\nCOMMENT 'A procedure'\r\nBEGIN\r\nSELECT 'Hello World !';\r\nEND |";
            string function = "DELIMITER |\r\nCREATE FUNCTION `A` ()\r\nRETURNS INT\r\nDETERMINISTIC\r\nBEGIN\r\nDECLARE b INT;\r\nSET b = 1;\r\nRETURN b;\r\nEND|";
            string trigger = "";
            string events = "DELIMITER |\r\nCREATE EVENT `C`\r\nON SCHEDULE EVERY 1 WEEK STARTS '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'\r\nDO BEGIN\r\nEND |";
            string view = "CREATE VIEW `E` AS SELECT 'view';";

            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                conn.Open();

                MySqlScript ms = new MySqlScript(conn);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                try
                {
                    ms.Query = function;
                    ms.Execute();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                try
                {
                    ms.Query = procedure;
                    ms.Execute();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                try
                {
                    ms.Query = events;
                    ms.Execute();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                try
                {
                    cmd.CommandText = "show tables;";
                    //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    //da = null;
                    string table1 = cmd.ExecuteScalar() + "";
                    //string table2 = dt.Rows[0][0] + "";
                    cmd.CommandText = "show columns from `" + table1;
                    string column = cmd.ExecuteScalar() + "";
                    trigger = "DELIMITER |\r\nCREATE TRIGGER `D`\r\nBEFORE INSERT ON `" + table1 + "`\r\nFOR EACH ROW\r\nBEGIN\r\nUpdate `" + table1 + "` SET `" + column + "` = `" + column + "` WHERE 1 = 2;\r\nEND |";
                    ms.Query = trigger;
                    ms.Execute();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                ms = null;

                

                try
                {
                    cmd.CommandText = view;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                cmd = null;

                conn.Close();
            }

            MessageBox.Show("Routines created successfully.\r\n\r\nProcedure:\r\n" + procedure +
                "\r\n\r\nFunction:\r\n" + function + "\r\n\r\nTrigger:\r\n" + trigger + "\r\n\r\nEvent:\r\n" +
                events + "\r\n\r\nView:\r\n" + view);
        }
    }
}
