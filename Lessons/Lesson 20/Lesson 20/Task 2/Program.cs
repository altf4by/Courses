using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    enum EnumType
    {
        Zero,  // = 0 
        One,   // = 1
        one = One,
        Two = 2,
        Three, // = 3
        Four,  // = 4
        Five = 5,
        Six = Nine,
        //Seven,
        Eight = 8, // Если не указать значение явно, то на 13 строке будет ошибка!
        Nine,
        Ten = 10,
        Infinite = 255
    }
    class Program
    {
        // Enum, как аргумент метода
        public static void MethodEnum(EnumType e)
        {
            switch (e)
            {
                case EnumType.Zero:
                    Console.WriteLine("Число 0");
                    break;
                case EnumType.Two:
                    Console.WriteLine("Число 2");
                    break;
                case EnumType.Five:
                    Console.WriteLine("Число 5");
                    break;
                case EnumType.Ten:
                    Console.WriteLine("Число 10");
                    break;

                default: break;
            }
        }

        static void Main()
        {
            MethodEnum(EnumType.Five);

            EnumType digit = EnumType.Ten;
            MethodEnum(digit);

            int i = (int)(++digit);
            Console.WriteLine(i);

            Console.WriteLine(digit); // Переменная изменилась.
            Console.WriteLine((int)EnumType.Ten); // Константа не изменилась.

            digit++;
            digit = digit + 5;

            // Недопустимо.
            //digit = ++EnumType.One;

            Console.ReadKey();
        }
    }

}
