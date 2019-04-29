using System;
using System.Collections;
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
            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("Before Squared odds: ");

            foreach (int item in mas)
                Console.Write("{0} ", item);

            Console.Write("\nAfter  Squared odds: ");

            foreach (int item in SquaredOdds(mas))
                Console.Write("{0} ", item);


            Console.ReadKey();
        }

        static IEnumerable SquaredOdds(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                if (mas[i] % 2 != 0)
                    yield return mas[i] * mas[i];
        }
    }
}
