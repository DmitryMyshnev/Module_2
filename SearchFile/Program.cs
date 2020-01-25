using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace SearchFile
{
    class Program
    {
          
       
        static void Main(string[] args)
        {                                                  
            string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            string pathOfUserDir = Path.Combine (Path.GetPathRoot(systemPath), "Users",Environment.UserName);
            string zipFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Myshnev.g2");
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Myshnev.txt");

            string currentPathDir = @"C:\Users\Dmitry\Desktop";
            
            var sd = new DirSearch();
            Console.WriteLine("Идет сканирование...");
            sd.DirS(currentPathDir);
            Console.WriteLine("Конец"); 
            Console.WriteLine("Количество файлов: "+sd.countFiles);
            Compress(filePath, zipFilePath);
            File.Delete(filePath);
            Console.ReadLine();
           
        }

        private static void Compress(string filePath, string zipFilePath)
        {
            using (FileStream fs = new FileStream(filePath,FileMode.Open))
            {
                using (FileStream dfs = File.Create(zipFilePath))
                {
                    using (GZipStream gzs = new GZipStream(dfs,CompressionMode.Compress))
                    {
                        fs.CopyTo(gzs);
                    }
                }
            }
        }

    }
}
