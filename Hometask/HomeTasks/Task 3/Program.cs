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
            Console.Write("Please, enter A (A must be less thatn B): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please, enter B (B must be bigger than A): ");
            int b = int.Parse(Console.ReadLine());
            int sum=0;

            for (int i = a+1; i < b; i++)
            {
                sum += i;
                if (i%2!=0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Total sum is {sum}");

            Console.ReadKey();
        }
    }
}
