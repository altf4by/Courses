using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int counter = 0;
            Console.WriteLine("Вводите текст, пока не будет нажата \".\"");
            do
            {
                ch = Console.ReadKey().KeyChar;
                if (ch==32)
                    counter++;

            } while (ch!=46);

            Console.WriteLine($"\nКоличество пробелов в тексте {counter}");
            Console.ReadKey(true);
        }
    }
}
