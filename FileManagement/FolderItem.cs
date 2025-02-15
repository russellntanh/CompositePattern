using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement
{
    public class FolderItem : FileSystemItem
    {
        List<FileSystemItem> files = new List<FileSystemItem>();

        public FolderItem(string name) : base(name)
        {
        }

        public void AddFile(FileSystemItem item)
        {
            files.Add(item);
        }

        public void RemoveFile(FileSystemItem item)
        {
            files.Remove(item);
        }

        public override decimal GetFileSize()
        {
            return files.Sum(x => x.GetFileSize());
        }

        public override void GetFileName()
        {
            Console.WriteLine("\t" +Name);
            foreach (FileSystemItem item in files)
            {
                Console.WriteLine("\t" +item.Name+ " : " + item.GetFileSize());
            }
        }
    }
}
