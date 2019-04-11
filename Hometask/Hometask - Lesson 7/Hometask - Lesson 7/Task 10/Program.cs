using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid;
            long number;
                int  temp;
            do
            {
                Console.Write("Enter your number: ");
                isValid = long.TryParse(Console.ReadLine(), out number);
                if (number <= 0)
                {
                    isValid = false;
                    Console.Clear();
                }

            } while (!isValid);

            int[] array = new int[number.ToString().Length];
            for (int i = 0; i < array.Length; i++)
                array[i] = int.Parse(number.ToString()[i].ToString());

            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = array[i];
                array[i] = temp;
            }

            DisplayArray("After reverse:", array);


            Console.ReadKey(true);
        }

        static void DisplayArray(string text, int[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i]);
            Console.WriteLine();
        }
    }
}
