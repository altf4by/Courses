using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidA, isValidB;
            int a, b;
            do
            {
                Console.Write("Введите значение A: ");
                isValidA = int.TryParse(Console.ReadLine(), out a);

                Console.Write("Введите значение B: ");
                isValidB = int.TryParse(Console.ReadLine(), out b);
            } while (!isValidA || !isValidB || !(a < b));

            while (a <= b)
            {
                for (int i = 1; i <= a; i++)
                    Console.Write($"{a} ");
                a++;
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
