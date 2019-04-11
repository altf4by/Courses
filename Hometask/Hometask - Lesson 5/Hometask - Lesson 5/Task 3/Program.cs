using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int counter = 32;
            Recurse(x, counter);
            Console.ReadLine();

        }

        static void Recurse(int x, int counter)
        {
            int temp = x % 2;

            if (x >= 2)
            {
                Recurse(x / 2, counter - 1);
            }
            if (x < 2)
            {
                for (int i = 0; i < counter; i++)
                {
                    Console.Write(0);
                }
            }
            Console.Write($"{temp}");
        }
    }
}

