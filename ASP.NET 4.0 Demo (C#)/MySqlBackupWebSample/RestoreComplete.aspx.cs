using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace MySqlBackupWebSample
{
    public partial class RestoreComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["connectionstring"] == null)
                Response.Redirect("~/Default.aspx");
            else
            {


                string fileLocation = "";

                if (Session["resultmsg"] != null)
                {
                    String strPathAndQuery = HttpContext.Current.Request.Url.PathAndQuery;
                    String strUrl = HttpContext.Current.Request.Url.AbsoluteUri.Replace(strPathAndQuery, "/dumpfiles/");
                    fileLocation = strUrl + System.IO.Path.GetFileName(Session["dumpfile"].ToString());

                    Label1.Text = Session["resultmsg"].ToString();
                }

                System.Data.DataTable dt = new System.Data.DataTable();
                MySqlConnection conn = new MySqlConnection(Session["connectionstring"].ToString());
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "SHOW TABLES;";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.AutoGenerateColumns = true;
                GridView1.DataBind();

                conn.Close();
                conn = null;
                cmd = null;
            }
        }

    }
}