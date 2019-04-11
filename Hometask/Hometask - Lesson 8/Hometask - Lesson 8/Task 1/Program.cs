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
            int[] array = { 1,2,3,4,5,6,7,8,9,10};

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Resize(ref array, int.Parse(Console.ReadLine()));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.ReadKey(true);
        }

        static void Resize(ref int[] array, int newSize)
        {
            int[] tempArray = new int[newSize];

            //if (array.Length<=newSize)
 array.CopyTo(tempArray, 0);
  

                    
            array = tempArray;
        }
    }
}
