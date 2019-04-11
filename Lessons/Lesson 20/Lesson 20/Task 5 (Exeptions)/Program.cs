using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5__Exeptions_
{
    class Program
    {
        static void Main()
        {
            int a = 1, n = 2;

            try
            {
                // Попытка деления на ноль.
                a = a / (2 - n);

                Console.WriteLine("a = {0}", a);
            }
            catch (Exception e)
            {
                Console.WriteLine("Обработка исключения.");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

    }
}
