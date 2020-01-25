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
        public int countFiles;

        public DirSearch() : base()
        {
                      
        }
                    
         public void  DirS(string path)
        {       
            try
            {
                foreach (string s in Directory.GetFiles(path))
                {
                    var file = new FileInfo(s);
                    if (FileDateYear(s) == DateTime.Today.Year)
                        if (DateTime.Today.DayOfYear - (FileDateDay(s)) < 14)
                        {
                          FileName.Add(file.Name);
                          countFiles++;
                        }
                }                
                WriteToFile(path, FileName);
                FileName.Clear();
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
