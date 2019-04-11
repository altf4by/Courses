using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your number: ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your number {userNumber} is {(userNumber % 2 == 0 ? "even" : "odd")}.");

            Console.WriteLine($"Your number {userNumber} is {((userNumber & 1) == 0 ? "even" : "odd")}.");


            Console.ReadKey();
        }
    }
}
