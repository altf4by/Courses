using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Random random = new Random();

            int[,] mass = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mass[i, j] = random.Next(50, 100);
                    Console.Write($"{mass[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
