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
            char[] array = new char[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)('a' + i * 2);
                Console.Write($"{array[i]} ");
            }

            Array.Reverse(array);
            Console.WriteLine();
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.ReadKey();
        }
    }
}
