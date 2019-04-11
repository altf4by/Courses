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
            int[] mass = { 7, 3, 2, 1, 4, 4, 5, 8 };
            int temp = 0;
            bool isEnterAllowed = true;

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
            Console.WriteLine();

            int length = mass.Length;
            while (isEnterAllowed)
            {
                isEnterAllowed = false;
                for (int i = 1; i < length; i++)
                {
                    if (mass[i - 1] > mass[i])
                    {
                        temp = mass[i - 1];
                        mass[i - 1] = mass[i];
                        mass[i] = temp;
                        isEnterAllowed = true;
                    }
                }
                length--;
            }

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
            Console.ReadLine();


        }
    }
}
