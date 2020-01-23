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
            string pathDesk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            string currentPathDir = @"C:\FTDI driver 2.8.14";
            
            var sd = new DirSearch();
            Console.WriteLine("Идет сканирование...");
            sd.DirS(currentPathDir);
            Console.WriteLine("Конец"); 
            Console.WriteLine("Количество файлов: "+sd.countFiles);

            FileInfo outputFile = new FileInfo(Path.Combine(pathDesk, "Myshnev.txt"));
            using (outputFile.Open(FileMode.OpenOrCreate))
            {

            }
            using (StreamWriter str = new StreamWriter(Path.Combine(pathDesk, "Myshnev.txt")))
            {
                for (int i = 0; i < 10; i++)
                {
                    
                    string[] s= sd.FileName[i].Split('\\');
                    string tab = "";
                    foreach (var item in s)
                    {
                        
                        str.WriteLine(tab + item);                                                
                        tab += "   ";                        
                     
                    }
                   
                }
                
            }
            //while (!sd.IsFileInclude(currentPathDir))
            //{
            //    currentPathDir = sd.CurrentDirInclude[0].FullName;
            //    foreach (var item in sd.ListOfDirs)
            //    {
            //        currentPathDir = Path.Combine(currentPathDir, item);
            //    }
            //}


            Console.ReadLine();
           

        }
    }
}
