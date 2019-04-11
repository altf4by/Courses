using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers of clients: ");
            int n = int.Parse(Console.ReadLine());
            int waysNumber=1;
            for (int i = n; i > 1; i--)
            {
                waysNumber *= i;
            }
            Console.WriteLine($"Total number of delivery ways is {waysNumber}");

            Console.ReadLine();
        }
    }
}
