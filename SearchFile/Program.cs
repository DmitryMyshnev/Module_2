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
            string  zipFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Myshnev.g2");
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Myshnev.txt");
                     
            var sd = new DirSearch();
            Console.WriteLine("Идет сканирование...");
            sd.DirS(pathOfUserDir);
            Console.WriteLine("Конец");
            Console.WriteLine("Количество файлов " + sd.countFiles);
            var zip = new WriteFileAndZip();
            zip.Compress(filePath, zipFilePath);
            File.Delete(filePath);
            Console.ReadLine();         
        }    
    }
}
