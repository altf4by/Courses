using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a, b;
            byte result;

            a = 127;
            b = 127;

            try
            {
                result = unchecked((byte)(a * b));
                Console.WriteLine("Unchecked-результат: " + result);

                result = checked((byte)(a * b)); // Эта инструкция вызывает исключение.

                Console.WriteLine("Checked-результат: " +
                                result); // Инструкция не будет выполнена.
            }
            catch (OverflowException exc)
            {
                // Перехватываем исключение.
                Console.WriteLine(exc.Message);
            }

            Console.ReadKey();

        }
    }
}
