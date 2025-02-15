using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement
{
    public class FileItem : FileSystemItem
    {
        public string Name { get; set; }
        public int FileSize { get; set; } 
        public FileItem(string name, int fileSize) : base(name)
        {
            FileSize = fileSize;
        }
        public override decimal GetFileSize()
        {
            return decimal.Divide(FileSize, 1024); 
        }
        public override void GetFileName()
        {
            Console.WriteLine(Name + " : " + FileSize);
        }
    }   
}
