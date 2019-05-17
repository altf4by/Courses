using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_Чтение_и_запись_символьного_потока
{
    class Program
    {
        static void Main()
        {

            FileInfo file = new FileInfo(@"C:\Text.txt");

            StreamWriter writer = file.CreateText();
            //StreamWriter writer = new StreamWriter(@"E:\Text.txt", true, Encoding.Default);
            writer.WriteLine("Первая строка текста...");
            writer.WriteLine("Вторая строка текста...");

            writer.Write(writer.NewLine);

            writer.WriteLine("Третья строка чисел:");

            for (int i = 0; i < 10; i++)
            {
                writer.Write(i + " ");
            }

            writer.Write(writer.NewLine);

            writer.Close();

            Console.WriteLine("Файл Text.txt создан и в него записан текст.");


            Console.ReadKey();
        }

    }
}
