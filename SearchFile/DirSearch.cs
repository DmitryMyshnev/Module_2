using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SearchFile
{
    class DirSearch : FileSearch
    {
        private string tempPath;
        private string dirNotPermission;
        
        private List<string> listOfDirs;
        private DirectoryInfo[] currentDirInclude;
        private FileInfo[] currentFileInDir;
        private DateTime currentTime;
        public int countFiles;
        public int countDirs;
       


        public DirSearch() : base()
        {
            listOfDirs = new List<string>();
           
        }

       
        public string DirNotPermission 
        {
            get => dirNotPermission; 
            set => dirNotPermission = value; 
        }
        public string TempPath
        {
            get => tempPath; 
            set => tempPath = value;
        }
        public List<string> ListOfDirs
        {
            get => listOfDirs;
            set => listOfDirs = value;
        }
        public DirectoryInfo[] CurrentDirInclude
        {
            get => currentDirInclude;
            set => currentDirInclude = value;
        }
     
         public void  DirS(string path)
        {
            try
            {
                foreach (string s in Directory.GetFiles(path))
                {
                    //if (FileDateYear(s) == DateTime.Today.Year)
                    //    if (currentTime.DayOfYear - (FileDateDay(s)) < 14)
                    //    {
                    //       
                    //        Console.WriteLine(s);                           
                    //    }
                   // Console.WriteLine(s);
                   FileName.Add(s);
                                     
                }
                WriteToFile(path, FileName); 
                foreach (string item in Directory.GetDirectories(path))
                {                                                                                           
                    DirS(item);                                 
                }
            }
             catch (Exception)
            {                         
            }
        }       
    }
}
