using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Program Files");


            if (directory.Exists)
            {

                Console.WriteLine("FullName    : {0}", directory.FullName);
                Console.WriteLine("Name        : {0}", directory.Name);
                Console.WriteLine("Parent      : {0}", directory.Parent);
                Console.WriteLine("CreationTime: {0}", directory.CreationTime);
                Console.WriteLine("Attributes  : {0}", directory.Attributes.ToString());
                Console.WriteLine("Root        : {0}", directory.Root);
                Console.Write("\n");

                FileInfo[] files = directory.GetFiles("*.txt",SearchOption.TopDirectoryOnly);
                Console.WriteLine("Найдено {0}  файлов\n", files.Length);

                foreach (FileInfo file in files)
                {
                    Console.WriteLine("File name : {0}", file.Name);
                    Console.WriteLine("File size : {0}", file.Length);
                    Console.WriteLine("Creation  : {0}", file.CreationTime);
                    Console.WriteLine("Attributes: {0}", file.Attributes.ToString());
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }

            Console.ReadKey();
        }

    }
}
