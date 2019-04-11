using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a number betwen 0 and 100: ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber>=0&&userNumber<=14)
                Console.WriteLine($"Your number {userNumber} is in the range betwen 0 and 14.");
            else if (userNumber >=15 && userNumber <= 35)
                Console.WriteLine($"Your number {userNumber} is in the range betwen 15 and 35.");
            else if (userNumber >= 36 && userNumber <= 50)
                Console.WriteLine($"Your number {userNumber} is in the range betwen 36 and 50.");
            else if (userNumber >= 50 && userNumber <= 100)
                Console.WriteLine($"Your number {userNumber} is in the range betwen 50 and 100.");
            else Console.WriteLine("Your number is NOT in the range between 0 and 100.");
            Console.ReadKey();
        }
    }
}
