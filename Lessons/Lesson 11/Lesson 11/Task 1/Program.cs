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
            int[] mas = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(mas));
            Console.ReadKey();
        }
        static int Sum (params int[] mas)
        {
            int sum=0;

            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            return sum;
        }
    }
}
