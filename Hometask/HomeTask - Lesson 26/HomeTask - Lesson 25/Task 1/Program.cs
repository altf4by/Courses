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
            FileInfo file = new FileInfo(@"C:\test.txt");

            FileStream fileStream = file.Create();

            fileStream.Close();

            //FileStream fs2 = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);

            Console.WriteLine("Введите текст, который будет записан в файл:");

            string text = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(@"C:\test.txt", false, Encoding.Default))
            {
                writer.Write(text);
            }

            Console.WriteLine("В файле находится следующий текст:");
            using (StreamReader reader = new StreamReader(@"C:\test.txt", Encoding.Default))
            {
                while (reader.Peek() != -1)
                    Console.Write((char)reader.Read());
            }
           
            Console.ReadKey();
        }
    }
}
