using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo targetFolder = new DirectoryInfo(@"C:\eLearn");

            string destPath = @"C:\TTT";

            if (targetFolder.Exists)
            {
                try
                {
                    targetFolder.CopyTo(destPath,true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("The end");
            Console.ReadKey(true);
        }

    }

    static class DirectoryExtension
    {
        public static void CopyTo(this DirectoryInfo directory, string destinationPath, bool createIfNotExists = false)
        {
            if (Directory.Exists(destinationPath))
                CopyContent(directory, destinationPath);
            else
            {
                if (createIfNotExists)
                {
                    Directory.CreateDirectory(destinationPath);
                    CopyContent(directory, destinationPath);
                }
                else
                    Console.WriteLine("Destination path doesn't exist");
            }               
        }

        public static void CopyContent(this DirectoryInfo directory, string destinationPath)
        {
            DirectoryInfo[] folders = directory.GetDirectories();

            string contentPath = Path.Combine(destinationPath, directory.Name);

            foreach (var folder in folders)
            {
                CopyContent(folder, contentPath);
            }

            DirectoryInfo contentFolder = Directory.CreateDirectory(contentPath);

            FileInfo[] files = directory.GetFiles();

            foreach (var file in files)
            {
                file.CopyTo(Path.Combine(contentFolder.FullName, file.Name));
            }
        }
    }

}
