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
        private List<string> fullPathToFile;
        private DirectoryInfo[] currentDirInclude;
        private FileInfo[] currentFileInDir;
        private DateTime currentTime;
        public DirSearch() : base()
        {
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
        public List<string> FullPathToFile 
        {
            get => fullPathToFile;
            set => fullPathToFile = value;
        }
      //  ArrayList currentNameDir = new ArrayList();
        public bool IsFileInclude(string path)
        {
            var di = new DirectoryInfo(path);
            fullPathToFile = new List<string>();
          
            currentDirInclude = di.GetDirectories();
            if (currentDirInclude.Length !=0 )
            {
                fullPathToFile.Add(currentDirInclude[0].Name);
              //  return false;
            }
            else
            {
               currentFileInDir = di.GetFiles();
               if(currentFileInDir.Length != 0)
                for (int i = 0; i < currentFileInDir.Length; i++)
                {
                 if(FileDateYear(currentFileInDir[i].FullName) == 2020 )
                   if(currentTime.DayOfYear - (FileDateDay(currentFileInDir[i].FullName)) < 14 )
                    {
                      FileName.Add(currentFileInDir[i].Name);
                     
                    }
                }
               
            }
            if(FileName.Count !=0 )
                return true;
            else
                return false;
        }

        public  bool SearchDesktop(string pathOfUserDir)
        {
            string[] dirs = Directory.GetDirectories(pathOfUserDir);
            foreach (string item in dirs)
            {
                TempPath = item;
                if (item != DirNotPermission)
                {
                    string[] pathDirInside = Directory.GetDirectories(item);
                    foreach (var s in pathDirInside)
                    {
                        if (s.Contains("Desktop"))
                        {
                            PathDesktop = Path.Combine(pathOfUserDir, "Desktop");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
