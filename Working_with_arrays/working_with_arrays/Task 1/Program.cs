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
            int size;
            do
            {
                Console.Write("Please, enter the size of the array: ");
                size = int.Parse(Console.ReadLine());               
            } while (size<=0);

            int[] array = new int[size];

            Console.Write("Here is your array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5 + 2;
                Console.Write($"{array[i]} ");
            }


            Console.ReadKey();
        }
    }
}
