using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 1000;
            Console.Write("Введите процентную ставку в процентах: ");
            decimal p = decimal.Parse(Console.ReadLine());
            int counter = 0;

            while (sum<=1100)
            {
                sum *= (1+p/100);
                counter++;
            }

            Console.WriteLine($"Итоговый размер вклада равен {sum} и будет достигнут через {counter} месяцев.");
            Console.ReadKey(true);
        }
    }
}
