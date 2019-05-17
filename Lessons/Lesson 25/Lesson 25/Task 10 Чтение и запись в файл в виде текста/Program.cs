using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Чтение_и_запись_в_файл_в_виде_текста
{
    class Program
    {
        static void Main()
        {
            FileStream file2 = new FileStream(@"C:\text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file2, Encoding.UTF8);


            writer.WriteLine("Первая строка текста...");

            writer.WriteLine("Вторая строка текста...");

            writer.Write(writer.NewLine);

            writer.WriteLine("Третья строка чисел:");

            for (int i = 0; i < 10; i++)
            {
                writer.Write(i + " ");
            }

            writer.Close();

            Console.WriteLine("Файл Text.txt создан и в него записан текст.");

            Console.WriteLine("Содержимое файла Text.txt:\n");

            StreamReader reader = File.OpenText(@"C:\Text.txt");
            string input;

            while ((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            // или Console.WriteLine(reader.ReadToEnd());

            reader.Close();

            Console.ReadKey();
        }
    }
}
