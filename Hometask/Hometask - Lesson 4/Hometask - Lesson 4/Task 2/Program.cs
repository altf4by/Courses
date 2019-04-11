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

            Operations(userNumber);

            Console.ReadKey();
        }

        static void Operations (int userNumber)
        {
            bool isPrime = true;               
            for (int i = 2; i < userNumber; i++)
            {
                if (userNumber%i==0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine($"Your number {userNumber} is:" +
                $"\n1. {((userNumber >= 0) ? "positive" : "negative")} " +
                $"\n2. {(isPrime ? "PRIME" : "NOT Prime")}" +
                $"\n3. {(userNumber % 2 == 0 ? "divisible" : "NOT divisible")} by 2." +
                $"\n4. {(userNumber % 5 == 0 ? "divisible" : "NOT divisible")} by 5." +
                $"\n5. {(userNumber % 3 == 0 ? "divisible" : "NOT divisible")} by 3." +
                $"\n6. {(userNumber % 6 == 0 ? "divisible" : "NOT divisible")} by 6." +
                $"\n7. {(userNumber % 9 == 0 ? "divisible" : "NOT divisible")} by 9.");
        }
    }
}
