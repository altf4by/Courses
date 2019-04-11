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
            Console.Write("Please, enter your number: ");
            int userNumber = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < userNumber; i++)
            {
                if (userNumber % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine($"Your number {userNumber} is {((userNumber >= 0) ? "positive" : "negative")} and " +
                $"{(isPrime ? "PRIME" : "NOT Prime")}.");

            Console.ReadKey();
        }
    }
}
