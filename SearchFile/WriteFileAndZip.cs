using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace SearchFile
{
    class WriteFileAndZip
    {    
        
        public  void Compress(string filePath, string zipFilePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                using (FileStream dfs = File.Create(zipFilePath))
                {
                    using (GZipStream gzs = new GZipStream(dfs, CompressionMode.Compress))
                    {
                        fs.CopyTo(gzs);
                    }
                }
            }
        }
    }
}
