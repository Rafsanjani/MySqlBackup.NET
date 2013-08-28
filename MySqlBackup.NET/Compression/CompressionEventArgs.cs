using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlBackup.Compression
{
    public class CompressionEventArgs : EventArgs
    {
        public CompressionType CompressionType { get; set; }
        public string SourceLocation { get; set; }
        public string DestinationLocation { get; set; }
        public long OriginalSize { get; set; }
        public long CompressedSize { get; set; }
        public Exception OccurredException { get; set; }
    }
}
