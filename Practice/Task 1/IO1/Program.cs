using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла");
            string file_name = Console.ReadLine();
            Console.WriteLine(File.ReadAllText(file_name));

            string[] files = File.ReadAllLines("2.txt");
            foreach (var file in files)
                Console.WriteLine(file);

            //Console.WriteLine("Введите имя файла");
            File.WriteAllText(@"C:\123.txt",files[1]);

            Console.ReadKey();
            
        }
    }
}
