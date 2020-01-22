using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchFile
{
    class FileSearch
    {
        private FileInfo[] fileByPath;
        private List<string> fileName;
        public FileSearch()
        {
            fileName = new List<string>();           
        }

        public FileInfo[] FileByPath
        { 
            get => fileByPath;
            set => fileByPath = value;
        }
        public List<string> FileName 
        {
            get => fileName; 
            set => fileName = value;
        }

        public int FileDateDay(string path)
        {
            var fi = new FileInfo(path);
            int day;
            int.TryParse(fi.CreationTime.DayOfYear.ToString(), out day);
            return day;
        }
        public int FileDateYear(string path)
        {
            var fi = new FileInfo(path);
            int yars;
            int.TryParse(fi.CreationTime.Year.ToString(), out yars);
            return yars;
        }
    }
}