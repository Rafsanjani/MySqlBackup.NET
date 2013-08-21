using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace MySqlBackupWebSample
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GlobalMethods.DeleteOldFile();
            if (!IsPostBack)
            {
                lbVersionInfo.Text = "(Demo Version: 1.3, ASP.NET 4.0, MySqlBackup.NET " + MySqlBackup.Version + ")";
            }
        }

        protected void btBackup_Click(object sender, EventArgs e)
        {
            lbMsg.Text = "";
            Session["connectionstring"] = txtConnection.Text;

            if (!TestConnection())
                return;

            Response.Redirect("~/Backup.aspx", true);
        }

        protected void btRestore_Click(object sender, EventArgs e)
        {
            lbMsg.Text = "";
            Session["connectionstring"] = txtConnection.Text;

            if (!TestConnection())
                return;

            if (FileUpload1.HasFile)
            {
                if (!System.IO.Directory.Exists(Server.MapPath("~/dumpfiles")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/dumpfiles"));
                }
                Session["dumpfile"] = Server.MapPath("~/dumpfiles/" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".sql");
                //Session["dumpfile"] = System.IO.Path.GetTempPath() + "SQLDump" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".sql";
                FileUpload1.SaveAs(Session["dumpfile"].ToString());
                Session["ignoreerror"] = CheckBox1.Checked;
                Response.Redirect("~/Restore.aspx", true);
            }
            else
            {
                lbMsg.Text = "You have not chosen a SQL Dump file to restore.";
            }
        }

        bool TestConnection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(txtConnection.Text);
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                lbMsg.Text = ex.Message;
                return false;
            }
        }
    }
}
