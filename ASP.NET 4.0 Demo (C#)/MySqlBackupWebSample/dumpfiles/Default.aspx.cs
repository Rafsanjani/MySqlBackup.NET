using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MySqlBackupWebSample.dumpfiles
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();   
        }

        void RefreshGridView()
        {
            GlobalMethods.DeleteOldFile();

            GridView1.RowDeleting += new GridViewDeleteEventHandler(GridView1_RowDeleting);
            GridView1.RowEditing += new GridViewEditEventHandler(GridView1_RowEditing);
            GridView1.SelectedIndexChanged += new EventHandler(GridView1_SelectedIndexChanged);

            string[] files = System.IO.Directory.GetFiles(Server.MapPath("~/dumpfiles"));

            DataTable dt = new DataTable();
            dt.Columns.Add("Filename");

            foreach (string s in files)
            {
                if (!s.EndsWith("sql"))
                    continue;
                dt.Rows.Add(System.IO.Path.GetFileName(s));
            }

            if (Session["filedeleted"] != null)
            {
                Label1.Text = Session["filedeleted"] + " is deleted.<br />";
                Session["filedeleted"] = null;
            }
            else
                Label1.Text = string.Empty;

            if (dt.Rows.Count == 0)
            {
                Label1.Text += "No files.";
            }
            else
                Label1.Text += string.Empty;

            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.Columns.Clear();
            GridView1.DataSource = dt;
            GridView1.AutoGenerateColumns = false;

            BoundField colnName = new BoundField();
            colnName.HeaderText = "Filename";
            colnName.DataField = "Filename";
            colnName.ReadOnly = true;

            CommandField colnDel = new CommandField();
            colnDel.DeleteText = "Delete";
            colnDel.ShowDeleteButton = true;

            CommandField colnDownload = new CommandField();
            colnDownload.EditText = "Download";
            colnDownload.ShowEditButton = true;

            CommandField colnView = new CommandField();
            colnView.ShowSelectButton = true;
            colnView.SelectText = "View";

            GridView1.Columns.Add(colnName);
            GridView1.Columns.Add(colnDel);
            GridView1.Columns.Add(colnDownload);
            GridView1.Columns.Add(colnView);

            GridView1.Columns[0].ItemStyle.Width = Unit.Pixel(150);
            GridView1.Columns[1].ItemStyle.Width = Unit.Pixel(55);
            GridView1.Columns[2].ItemStyle.Width = Unit.Pixel(70);
            GridView1.Columns[3].ItemStyle.Width = Unit.Pixel(70);

            GridView1.SelectedIndex = -1;

            GridView1.DataBind();

            Session.Clear();
        }

        void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.Clear();
            Session["viewfile"] = GridView1.Rows[GridView1.SelectedIndex].Cells[0].Text;
            Response.Redirect("~/View.aspx");
        }

        void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string targetFile = Server.MapPath("~/dumpfiles") + "\\" + GridView1.Rows[e.NewEditIndex].Cells[0].Text;
            Response.ContentType = "text/plain";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + GridView1.Rows[e.NewEditIndex].Cells[0].Text);
            Response.TransmitFile(targetFile);
            Response.End();
        }

        void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                System.IO.File.Delete(Server.MapPath("~/dumpfiles") +"\\"+ GridView1.Rows[e.RowIndex].Cells[0].Text);
                Session["filedeleted"] = GridView1.Rows[e.RowIndex].Cells[0].Text;
                RefreshGridView();
            }
            catch (Exception ex)
            {
                Session["errmsg"] = ex.ToString();
                Response.Redirect("~/Error.aspx");
            }
        }
    }
}