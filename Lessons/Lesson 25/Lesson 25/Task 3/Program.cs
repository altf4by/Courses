using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\");
            Console.WriteLine(directory.FullName);
            if (directory.Exists)
            {
                directory.CreateSubdirectory("SUBDIR");

                directory.CreateSubdirectory(@"MyDir\SubMyDir");

                Console.WriteLine("Директории созданы.");
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }

            Console.ReadKey();
        }

    }
}
