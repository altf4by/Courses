using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Create_File
{
    class Program
    {
        static void Main()
        {
            FileInfo file = new FileInfo(@"C:\Test.txt");

            using (FileStream stream = file.Create())
            {
                Console.WriteLine("Full Name   : {0}", file.FullName);
                Console.WriteLine("Attributes  : {0}", file.Attributes.ToString());
                Console.WriteLine("CreationTime: {0}", file.CreationTime);

                Console.WriteLine("Нажмите любую клавишу для удаления файла.");
                Console.ReadKey();
            }

            // или убрать using ()
            //stream.Close();

            file.Delete();

            Console.WriteLine("Файл успешно удален.");


            Console.ReadKey();
        }

    }
}
