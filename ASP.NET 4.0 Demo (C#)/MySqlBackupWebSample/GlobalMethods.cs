using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySqlBackupWebSample
{
    public class GlobalMethods
    {
        public static void DeleteOldFile()
        {
            string timeNow = DateTime.Now.AddMinutes(-15).ToString("yyyyMMddHHmmss");
            long iTimeNow = Convert.ToInt64(timeNow);
            string[] oldFiles = System.IO.Directory.GetFiles(HttpContext.Current.Server.MapPath("~/dumpfiles"));
            foreach (string s in oldFiles)
            {
                if (!s.EndsWith("sql"))
                    continue;
                string file = System.IO.Path.GetFileNameWithoutExtension(s);
                file = file.Replace("-", string.Empty);
                long fileTime = Convert.ToInt64(file);
                if (fileTime < iTimeNow)
                {
                    try
                    {
                        System.IO.File.Delete(s);
                    }
                    catch 
                    {
                      
                    }
                }
            }
        }

        public static string GetHtmlString(string input)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char c in input)
            {
                switch (c)
                {
                    case '&':
                        sb.AppendFormat("&amp;");
                        break;
                    case '"':
                        sb.AppendFormat("&quot;");
                        break;
                    case '\'':
                        sb.AppendFormat("&#39;");
                        break;
                    case '<':
                        sb.AppendFormat("&lt;");
                        break;
                    case '>':
                        sb.AppendFormat("&gt;");
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }
            return sb.ToString();
        }
    }
}