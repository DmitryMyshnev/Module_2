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
                              
            string pathDesk;
            bool searchDesktop = true;
           
            string currentPathFile = "";
            string currentPathDir = "";
            string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            string pathOfUserDir = Path.Combine (Path.GetPathRoot(systemPath), "Users");
            currentPathDir = @"C:\1Projects";
           
            var sd = new DirSearch();
            while (searchDesktop)
            {
                try
                {
                    searchDesktop = sd.SearchDesktop(pathOfUserDir);
                    pathDesk = sd.PathDesktop;
                }
                catch (UnauthorizedAccessException)
                {
                    sd.DirNotPermission = sd.TempPath;
                    continue;
                }
            }

            while(!sd.IsFileInclude(currentPathDir))
            {
                foreach (var item in sd.FullPathToFile)
                {
                    currentPathDir = Path.Combine(currentPathDir, item);
                }
            }
            

            Console.ReadLine();
            //try
            //{
            //    string[] fiels = Directory.GetFiles(pathDesktop);
            //    foreach (string s in fiels)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //catch (UnauthorizedAccessException)
            //{

            //    Console.WriteLine("no accsept");
            //}
            // var tm = dirInfo.CreationTime.DayOfYear;

            // Console.WriteLine(tm);
            //// Console.WriteLine($"dir together: {dirInfo.GetDirectories(dirName)}");
            // Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            // Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            // Console.WriteLine($"Корневой каталог: {dirInfo.Root}");

        }
    }
}
