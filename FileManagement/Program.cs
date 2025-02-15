namespace FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSystemItem f1 = new FileItem("file1.txt", 2000);
            FileSystemItem f2 = new FileItem("file2.txt", 4000);
            FileSystemItem f3 = new FileItem("file3.txt", 4000);
            FileSystemItem f4 = new FileItem("file4.exe", 12000);
            FileSystemItem f5 = new FileItem("file5.exe", 200000);

            FolderItem folder1 = new FolderItem("Folder1");
            folder1.AddFile(f1);
            folder1.AddFile(f2);

            FolderItem folder2 = new FolderItem("Folder2");
            folder2.AddFile(f3);
            folder2.AddFile(f4);

            FolderItem folder3 = new FolderItem("Folder3");

            FolderItem rootFolder = new FolderItem("MyData");
            rootFolder.AddFile(folder1);
            rootFolder.AddFile(folder2);
            rootFolder.AddFile(folder3);
            rootFolder.AddFile(f5);

            Console.WriteLine("\nFile and Folder information: ");
            rootFolder.GetFileName();
            Console.WriteLine("Total Size of root folder: " + rootFolder.GetFileSize().ToString());
        }
    }
}
