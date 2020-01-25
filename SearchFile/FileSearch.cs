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
        private List<string> fileName;      
        private  string pathDesk;
       
        public FileSearch()
        {
            fileName = new List<string>();
            pathDesk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);           
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
                long pos = 0;
                if (file.Count != 0)
                {                  
                    foreach (string item in tmp)
                    { 
                        str.Seek(pos, SeekOrigin.Current);
                        input = Encoding.Default.GetBytes(item + "\n");
                        pos += input.Length - 1;   
                        str.Write(input, 0, input.Length);   
                    }
                }               
                foreach (string item in file)
                {
                    str.Seek(pos, SeekOrigin.Current);
                    input = Encoding.Default.GetBytes(item + "\n");                  
                    str.Write(input, 0, input.Length);
                }

             }
        }   
    }
}