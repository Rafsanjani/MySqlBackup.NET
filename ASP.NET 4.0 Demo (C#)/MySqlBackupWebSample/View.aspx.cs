using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySqlBackupWebSample
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["viewfile"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                try
                {
                    Button1.Text = "Download " + Session["viewfile"].ToString();
                    Label2.Text = Session["viewfile"].ToString();
                    string targetFile = Server.MapPath("~/dumpfiles") + "\\" + Session["viewfile"].ToString();
                    string content = System.IO.File.ReadAllText(targetFile);
                    content = GlobalMethods.GetHtmlString(content);
                    content = content.Replace("\r\n", "<br />").Replace("\n", "<br />");
                    LabelContent.Text = content;
                }
                catch (Exception ex)
                {
                    Session["errmsg"] = ex.ToString();
                    Response.Redirect("~/Error.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string targetFile = Server.MapPath("~/dumpfiles") + "\\" + Session["viewfile"].ToString();
            Response.ContentType = "text/plain";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Session["viewfile"].ToString());
            Response.TransmitFile(targetFile);
            Response.End();
        }
    }
}