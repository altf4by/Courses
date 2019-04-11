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
            int[] array = new int[11];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)Math.Pow(2, i);
                Console.Write($"{array[i]} ");
            }

            Console.ReadKey();
        }
    }
}
