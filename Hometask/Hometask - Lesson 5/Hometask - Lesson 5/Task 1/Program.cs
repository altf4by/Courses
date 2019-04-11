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
            Random random = new Random();

            Console.Write("Please, enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int sum = 0;
            int max = 0;
            int min = 100;

            Console.Write("Here are odd numbers from array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);               
                sum += array[i];
               
                if (array[i]>=max)
                    max = array[i];
                if (array[i]<=min)
                    min = array[i];
                if (array[i] % 2 != 0)
                    Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            ShowArray("Here is your array: ", array);
            Console.WriteLine($"1. Max value in array is {max}." +
                $"\n2. Min value in array is {min}." +
                $"\n3. Sum is {sum}." +
                $"\n4. Average is {sum / size}.");

            //2nd decision:
            //bubble sort
            //for (int i = 1; i < array.Length; i++)
            //{
            //    for (int j = 1; j < array.Length; j++)
            //    {
            //        if (array[j] < array[j - 1])
            //        {
            //            int temp = array[j];
            //            array[j] = array[j - 1];
            //            array[j - 1] = temp;
            //        }
            //    }
            //}

            //ShowArray("Here is your array after sort: ", array);
            //Console.WriteLine($"1. Max value in array is {array[size-1]}." +
            //    $"\n2. Min value in array is {array[0]}." +
            //    $"\n3. Sum is {sum}." +
            //    $"\n4. Average is {sum/size}.");

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i]%2!=0)
            //    {
            //        Console.Write($"{array[i]} " );
            //    }
            //}

            Console.ReadKey();
        }
        static void ShowArray(string text, int[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

    }
}
