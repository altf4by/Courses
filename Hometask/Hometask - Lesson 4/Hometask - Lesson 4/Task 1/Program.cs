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
                Console.Write("Please, enter a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Please, enter b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Please, enter the number of operation: 1 - Add, 2 -Sub, 3- Mul, 4 - Div: ");
                int c = int.Parse(Console.ReadLine());
     
            switch (c)
            {
               case 1: Add(a, b); break;
               case 2: Sub(a, b); break;
               case 3: Mul(a, b); break;
               case 4: Div(a, b); break;
                default:
                    Console.WriteLine("\nYou chosed incorrect opperation.");
                    break;
            }

            Console.ReadLine();
        }

        static void Add(int a, int b) => Console.WriteLine($"\nResult of adding {a} and {b} is {a+b}.");
        static void Sub(int a, int b) => Console.WriteLine($"\nResult of substraction {a} and {b} is {a - b}.");
        static void Mul(int a, int b) => Console.WriteLine($"\nResult of multiply of {a} and {b} is {a * b}.");

        static void Div (int a, int b)
        {
            if (b==0)
                Console.WriteLine("You can't divide by 0");
            else
                Console.WriteLine($"Result of dividing {a} and {b} is {a / b}.");
        }




    }
}
