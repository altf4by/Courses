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
            Console.WriteLine("Please, enter size of the array");

            int size = int.Parse(Console.ReadLine());
            Random r = new Random();

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i]= r.Next(50, 100);
                Console.Write($"{array[i]} ");
            }
            Console.ReadKey();
        }
    }
}
