using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    enum EnumType : byte // Явно указываем использовать тип byte.
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(EnumType.One);
            Console.WriteLine((byte)EnumType.One);

            EnumType digit = EnumType.Zero;
            Console.WriteLine(digit);
            Console.WriteLine((byte)digit);

            Console.ReadKey();
        }
    }

}
