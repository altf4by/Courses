using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
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
                unchecked
                {
                    a = 127;
                    b = 127;
                    result = (byte)(a * b);
                    Console.WriteLine("Unchecked-результат: " + result);

                    a = 125;
                    b = 5;
                    result = (byte)(a * b);
                    Console.WriteLine("Unchecked-результат: " + result);
                }

                checked
                {
                    a = 2;
                    b = 7;
                    result = unchecked((byte)(a * b)); // Все в порядке.
                    Console.WriteLine("Checked-результат: " + result);
                    a = 127;
                    b = 127;
                    result = (byte)(a * b); // Здесь должно
                    // быть сгенерировано исключение.
                    Console.WriteLine("Checked-результат: " +
                                      result); // Эта инструкция не выполнится.
                }
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.ReadKey();

        }
    }
}
