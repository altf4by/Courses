using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int countA = 0, countB = 0, total = 0;
            GetValue(out int a, "A");
            GetValue(out int b, "B");
            GetValue(out int c, "C");

            while (c <= a)
            {
                countA++;
                a -= c;
            }
            while (c <= b)
            {
                countB++;
                b -= c;
            }

            if (countA >= 1 & countB >= 1)
                total = countA * countB;
            else Console.WriteLine("Невозможно разместить ни одного квадрата.");

            int s = a * c + b * (a + countA * c);


            Console.WriteLine($"Количество квадратов по стороне А: {countA}");
            Console.WriteLine($"Количество квадратов по стороне B: {countB}");
            Console.WriteLine($"На прямоугольнике можно разместить {total} квадратов");
            Console.WriteLine($"Оставшаяся незаполненной площадь равна: {s}");
            Console.ReadKey(true);
        }

        static void GetValue(out int value, string side)
        {
            bool isValid = false;
            do
            {
                Console.Write($"Введите значение {side}: ");
                isValid = int.TryParse(Console.ReadLine(), out value);
            } while (!isValid || value <= 0);
        }
    }
}
