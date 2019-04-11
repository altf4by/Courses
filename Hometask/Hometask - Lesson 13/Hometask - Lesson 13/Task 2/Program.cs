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
            DynamicArray array = new DynamicArray() ;
            DynamicArray array2 = new DynamicArray(7);
            array.Add(1);
            array.Add(2);
            array.Insert(4, 1);
            int[] addedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,13,14,15,16,17,18,19};
            array.AddRange(addedArray);
            array.RemoveAt(1);

            array.BubbleSort(true);


            Console.ReadKey(true);

        }
    }
}
