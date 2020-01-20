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
        static string  tempPath = "";
        static string pathDesktop = "";
        static  string dirNotPermission = "";
        static bool SearchDesktop(string pathOfUserDir)
        {         
            string[] dirs = Directory.GetDirectories(pathOfUserDir);
            foreach (string item in dirs)
            {
                tempPath = item;
                if (item != dirNotPermission)
                {
                    string[] pathDirInside = Directory.GetDirectories(item);
                    foreach (var s in pathDirInside)
                    {
                        if (s.Contains("Desktop"))
                        {
                            pathDesktop = Path.Combine(pathOfUserDir, "Desktop");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            bool searchDesktop = true;
           
            string currentPathFile = "";
            string currentPathDir = "";
            string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            string pathOfUserDir = Path.Combine (Path.GetPathRoot(systemPath), "Users");

            // var currenDirInfo = new DirectoryInfo(pathDesktop);

            while (searchDesktop)
            {
                try
                {
                   searchDesktop = SearchDesktop(pathOfUserDir);
                    if (searchDesktop)
                    {
                        Console.WriteLine("Not found Desktop");
                        break;
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    dirNotPermission = tempPath;
                    continue;
                }
            }

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
            Console.ReadLine();
        }
    }
}
