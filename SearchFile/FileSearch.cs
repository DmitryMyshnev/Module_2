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
        
        string pathDesk;
        private string pathDesktop;
        public FileSearch()
        {
            fileName = new List<string>(); 
             pathDesk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        public string PathDesktop
        {
            get => pathDesktop;
            set => pathDesktop = value;
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
        public void WriteToFile(string path,List<string> file)
        {          
            using (FileStream str = new FileStream(Path.Combine(pathDesk, "Myshnev.txt"), FileMode.Append))
            {                
                string[] tmp = path.Split('\\');
                byte[] input;               
                long t = 0;
                for (int i = 0; i < tmp.Length; i++)
                {                   
                    str.Seek(t, SeekOrigin.Current);                  
                    input = Encoding.Default.GetBytes(tmp[i] + "\n");  
                    t += input.Length-1;
                    str.Write(input, 0, input.Length);
                }            
             }
        }
       private string Tab(long lenght)
        {
            string outputLenght = "";
            for (int i = 0; i < lenght; i++)
            {
                outputLenght += " ";
            }
            return outputLenght;
        }
    }
}