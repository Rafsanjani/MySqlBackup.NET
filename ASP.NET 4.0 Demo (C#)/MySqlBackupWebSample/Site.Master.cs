using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySqlBackupWebSample
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "MySqlBackup.NET Demo";
            Page.MetaDescription = "A Programming Tool(Class) to Backup and Restore MySQL Database in .NET Programming Language (C#/VB.NET/ASP.NET)";
            Page.MetaKeywords = "mysql, backup, restore, C#, VB.NET, ASP.NET, c sharp, c-sharp, databaseexport, import ";
        }
    }
}
