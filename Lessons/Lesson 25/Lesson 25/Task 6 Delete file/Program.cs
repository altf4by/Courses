using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Delete_file
{
    class Program
    {
        static void Main()
        {
            FileInfo file = new FileInfo(@"E:\Test.txt");

            FileStream stream = file.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);

            Console.WriteLine("Full Name   : {0}", file.FullName);
            Console.WriteLine("Attributes  : {0}", file.Attributes.ToString());
            Console.WriteLine("CreationTime: {0}", file.CreationTime);

            Console.WriteLine("Нажмите любую клавишу для удаления файла.");
            Console.ReadKey();

            stream.Close();

            file.Delete();

            Console.WriteLine("Файл успешно удален.");

            Console.ReadKey();
        }

    }
}
