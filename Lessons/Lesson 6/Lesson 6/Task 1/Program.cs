using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 7, 3, 2, 1, 4, 4, 5, 8 };
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
            int temp = 0;
            for (int i = 1; i < mass.Length; i++)
            {
                for (int j = mass.Length-1; j >= i; j--)
                {
                    if (mass[j-1]>mass[j])
                    {
                        temp = mass[j - 1];
                        mass[j - 1] = mass[j];
                        mass[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
            Console.ReadKey();
        }
    }
}
