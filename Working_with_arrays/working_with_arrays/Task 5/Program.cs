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
            Random rand = new Random();

            Console.Write("Please, enter size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int min = 100;
            int position=0;

            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
                Console.Write($"{array[i]} ");
                if (min>array[i])
                {
                    min = array[i];
                    position = i;
                }
            }
            Console.WriteLine($"\nMin value is {min} and on the {position} position.");



            Console.ReadKey();
        }
    }
}
