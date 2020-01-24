using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchFile
{
    class Program
    {
          
       
        static void Main(string[] args)
        {                                                  
            string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            string pathOfUserDir = Path.Combine (Path.GetPathRoot(systemPath), "Users",Environment.UserName);
           
            
            string currentPathDir = @"C:\FTDI driver 2.8.14";
            
            var sd = new DirSearch();
            Console.WriteLine("Идет сканирование...");
            sd.DirS(currentPathDir);
            Console.WriteLine("Конец"); 
            Console.WriteLine("Количество файлов: "+sd.countFiles);
           
            Console.ReadLine();
           

        }
    }
}
