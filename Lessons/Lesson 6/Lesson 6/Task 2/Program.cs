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
            int[] array = { 7, 3, 2, 1, 4, 4, 5, 8 };
            bool upDown = true;
            string chose="";

            do
            {
                Console.WriteLine("Enter, up or down");
                chose = Console.ReadLine();
                if (chose == "up")
                {
                    upDown = true;
                }
                else { upDown = false; }
            } while (chose == "up"||chose=="down");

            BubbleSort(array, upDown);

            Console.ReadLine();
            
        }

        static void BubbleSort(int[] array, bool upDown)
        {
            int temp;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j >= i; j--)
                {
                    if (upDown? array[j - 1] > array[j]: array[j - 1] < array[j])
                    {
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }            
        }
        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

    }
}
