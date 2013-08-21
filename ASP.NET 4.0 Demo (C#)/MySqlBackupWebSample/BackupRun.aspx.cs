using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace MySqlBackupWebSample
{
    public partial class BackupRun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["connectionstring"] == null)
                Response.Redirect("~/Default.aspx");
            else
            {
                GlobalMethods.DeleteOldFile();

                MySqlBackup mb = null;
                Exception ex1 = null;

                try
                {
                    Session["dumpfile"] = Server.MapPath("~/dumpfiles/" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".sql");

                    mb = new MySqlBackup(Session["connectionstring"].ToString());
                    mb.ExportInfo.FileName = Session["dumpfile"].ToString();
                    mb.Export();
                }
                catch (Exception ex2)
                {
                    ex1 = ex2;
                }

                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("Backup " + mb.ExportInfo.CompleteArg.CompletedType + "<br />");
                sb.Append("Time Start: " + mb.ExportInfo.CompleteArg.TimeStart.ToString() + "<br />");
                sb.Append("Time End: " + mb.ExportInfo.CompleteArg.TimeEnd.ToString() + "<br />");
                sb.Append("Time Used: " + mb.ExportInfo.CompleteArg.TimeUsed.Seconds + " s " + mb.ExportInfo.CompleteArg.TimeUsed.Milliseconds + " ms<br />");
                if (mb.ExportInfo.CompleteArg.CompletedType == ExportCompleteArg.CompleteType.Error)
                {
                    sb.Append("Error Message:<br /><br />");
                    sb.Append(ex1.ToString().Replace("\r\n", "<br /><br />"));
                }

                Session["resultmsg"] = sb.ToString();

                Response.Redirect("~/BackupComplete.aspx", true);
            }
        }
    }
}