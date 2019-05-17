using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15_Считывание_бинарного_текста
{
    class Program
    {
        static void Main()
        {
            FileStream file = File.Open(@"C:\test.txt", FileMode.Open);

            BinaryReader reader = new BinaryReader(file);

            long number = reader.ReadInt64();
            byte[] bytes = reader.ReadBytes(4);
            string s = reader.ReadString();

            reader.Close();

            Console.WriteLine(number);
            foreach (byte b in bytes)
            {
                Console.Write("[{0}]", b);
            }

            Console.WriteLine();
            Console.WriteLine(s);

            Console.ReadKey();
        }

    }
}
