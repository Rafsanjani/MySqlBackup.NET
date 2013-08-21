using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySqlBackupWebSample
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["errmsg"] != null)
            {
                Label1.Text = Session["errmsg"].ToString().Replace("\r\n","<br />");
                Session.Clear();
            }
            else
                Response.Redirect("~/Default.aspx");
        }
    }
}