using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySqlBackupWebSample
{
    public partial class BackupComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["dumpfile"] == null || Session["resultmsg"] == null ||
                !System.IO.File.Exists(Session["dumpfile"].ToString()))
                Response.Redirect("~/Default.aspx");
            else
            {
                string fileLocation = "";

                String strPathAndQuery = HttpContext.Current.Request.Url.PathAndQuery;
                String strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(strPathAndQuery, "/dumpfiles/");
                fileLocation = strUrl + System.IO.Path.GetFileName(Session["dumpfile"].ToString());

                Label1.Text = Session["resultmsg"] + "<br />Dump File is created and stored temporarily at: " + fileLocation;

                Button1.Text = fileLocation;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.ContentType = "text/plain";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + System.IO.Path.GetFileName(Session["dumpfile"].ToString()));
            Response.TransmitFile(Session["dumpfile"].ToString());
            Response.End();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string content = System.IO.File.ReadAllText(Session["dumpfile"].ToString(), System.Text.Encoding.UTF8);
            content = GlobalMethods.GetHtmlString(content);
            content = content.Replace("\r\n", "<br />");
            content = content.Replace("\n", "<br />");
            Button2.Visible = false;
            Label2.Text = "Content of " +
                System.IO.Path.GetFileName(Session["dumpfile"].ToString()) +
                "<br /><br />" +
                content;
        }
    }
}