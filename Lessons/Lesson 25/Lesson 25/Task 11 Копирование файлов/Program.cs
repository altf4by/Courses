using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_Копирование_файлов
{
    class Program
    {
        static void Main()
        {
            FileInfo file = new FileInfo(@"C:\Windows\notepad.exe");

            try
            {
                file.CopyTo(@"E:\notepad.exe");
                Console.WriteLine("Файл успешно скопирован!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

    }
}
