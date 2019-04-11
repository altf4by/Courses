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
            Random random = new Random();

            Console.Write("Please, enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Console.Write("Here are your array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            ShowArray("Reverse array: ", ReverseArray(array));
            ShowArray("Reverse array 2nd variant: ", ReverseArray2(array));

            //ShowArray("Reverse array 2nd variant: ", ReverseArray2(array));
            Console.WriteLine();
            int index;
            do
            {
                Console.Write("Please, enter position of array to copy: ");
                index = int.Parse(Console.ReadLine());
            } while (index<=0);
            
            Console.Write("Please, enter count of elements of array to copy: ");
            int count = int.Parse(Console.ReadLine());

            ShowArray("Subarray: ", SubArray(array,index,count));

            Console.ReadKey();
        }

        static void ShowArray(string text, int[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static int[] ReverseArray (int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length/2; i++)
            {
                reversedArray[array.Length - 1 - i] = array[i];
            }
            return reversedArray;
        }
        static int[] ReverseArray2(int[] array)
        {
            Array.Reverse(array);
            return array;
        }
        static void ReverseArray3(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = array[i];
                array[i] = temp;
            }
        }
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] subArray = new int[count];
            int q = 0;
            
            for (int i = index-1; i < index-1+count; i++)
            {
                subArray[q++] = i >= array.Length ? 1 : array[i];             
            }

            return subArray;
        }       
    }
}
