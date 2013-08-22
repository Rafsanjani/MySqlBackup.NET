using System;
using System.Collections.Generic;
using System.Text;

namespace MySqlBackup.Compression
{
    public enum CompressionType
    {
        /// <summary>
        /// Use no compression. Default.
        /// </summary>
        Off = 0,

        /// <summary>
        /// Uses DotNetZip to create a standard ZIP file with it's "best compression".
        /// </summary>
        ZipFile = 1,

        /// <summary>
        /// Uses the ULTRA option within 7Zip. Note, REQUIRES 7ZIP TO BE INSTALLED!!
        /// </summary>
        SevenZip = 2
    }
}
