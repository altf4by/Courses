using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temporary_folder";
            DirectoryInfo directory = new DirectoryInfo(path);
            directory.Create();

            CreateDocFiles(directory.FullName);

            if (directory.Exists)
                directory.CreateSubdirectory("Subdir");

            using (FileStream fs = new FileStream(directory.FullName + @"\Subdir\file.doc", FileMode.OpenOrCreate)) { }

            FileInfo[] files = directory.GetFiles("*.doc", SearchOption.AllDirectories);

            foreach (FileInfo file in files)
                file.Attributes |= FileAttributes.Hidden; // побитово добавляет атрибут, не трогая иные атрибуты... 
 
            Console.WriteLine("Press any key to back files visible");
            Console.ReadKey(true);

            foreach (FileInfo file in files)
                if (file.Attributes ==FileAttributes.Hidden)
                    file.Attributes ^= FileAttributes.Hidden; // побитово удаляет атрибут
                
             
            Console.ReadKey();
        }

        static void CreateDocFiles(string path)
        {
            if (Directory.Exists(path))
            {
                using (FileStream file1 = new FileStream(path + @"\file1.doc", FileMode.OpenOrCreate)) { }

                using (FileStream file2 = new FileStream(path + @"\file2.doc", FileMode.OpenOrCreate)) { }

                using (FileStream file3 = new FileStream(path + @"\file3.doc", FileMode.OpenOrCreate)) { }                
            }
        }
    }
}
