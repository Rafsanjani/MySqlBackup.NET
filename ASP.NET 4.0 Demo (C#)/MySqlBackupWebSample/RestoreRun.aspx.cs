using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace MySqlBackupWebSample
{
    public partial class RestoreRun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GlobalMethods.DeleteOldFile();

            if (Session["connectionstring"] == null || Session["dumpfile"] == null)
                Response.Redirect("~/Default.aspx", true);
            else
            {
                MySqlBackup mb=null;
                Exception ex1 = null;
                try
                {
                    mb = new MySqlBackup(Session["connectionstring"].ToString());
                    mb.ImportInfo.FileName = Session["dumpfile"].ToString();
                    mb.Import();
                }
                catch (Exception ex2)
                {
                    ex1 = ex2;
                }

                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("Restore " + mb.ImportInfo.CompleteArg.CompletedType + "<br />");
                sb.Append("Time Start: " + mb.ImportInfo.CompleteArg.TimeStart + "<br />");
                sb.Append("Time End: " + mb.ImportInfo.CompleteArg.TimeEnd + "<br />");
                sb.Append("Time Used: " + mb.ImportInfo.CompleteArg.TimeUsed.Seconds + " s " + mb.ImportInfo.CompleteArg.TimeUsed.Milliseconds + " ms<br />");

                if (mb.ImportInfo.CompleteArg.HasErrors)
                {
                    sb.Append("Displaying Last Error:<br /><br />" + ex1 + "<br /><br />");
                }

                Session["resultmsg"] = sb.ToString();

                Response.Redirect("~/RestoreComplete.aspx", true);
            }
        }
    }
}