using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement
{
    public abstract class FileSystemItem
    {
        public string Name { get; set; }
        public FileSystemItem(string name)
        {
            Name = name;
        }
        public abstract decimal GetFileSize();
        public abstract void GetFileName();
    }
}
