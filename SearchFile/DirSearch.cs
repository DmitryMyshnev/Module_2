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
        private string pathDesktop;
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

        public string PathDesktop
        {
            get => pathDesktop;
            set => pathDesktop = value;
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

        public bool IsFileInclude(string path)
        {
            var di = new DirectoryInfo(path);
                      
            CurrentDirInclude = di.GetDirectories();
            if (CurrentDirInclude.Length !=0 )
            {
                listOfDirs.Add(CurrentDirInclude[0].Name);            
            }
            else
            {
               currentFileInDir = di.GetFiles();
                if (currentFileInDir.Length != 0)
                {
                    for (int i = 0; i < currentFileInDir.Length; i++)
                    {
                        if (FileDateYear(currentFileInDir[i].FullName) == DateTime.Today.Year)
                            if (currentTime.DayOfYear - (FileDateDay(currentFileInDir[i].FullName)) < 14)
                            {
                                FileName.Add(currentFileInDir[i].Name);                               
                            }
                    }
                   
                   
                }
               
            }
            if(FileName.Count !=0 )
                return true;
            else
                return false;
        }

         public void  DirS(string path)
        {
            try
            {
                foreach (string item in Directory.GetDirectories(path))
                {                 
                    try
                    {
                       foreach (string s in Directory.GetFiles(item))
                        {
                            if (FileDateYear(s) == DateTime.Today.Year)
                                if (currentTime.DayOfYear - (FileDateDay(s)) < 14)
                                {
                                    FileName.Add(s);
                                    Console.WriteLine(s);
                                    countFiles++;
                                }
                            FileName.Add(s);
                            Console.WriteLine(s);
                        }
                    }
                    catch (Exception) {}                                                          
                    DirS(item);                                 
                }
            }
             catch (Exception)
            {                         
            }
        }       
    }
}
