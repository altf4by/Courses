using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    enum EnumType
    {
        Zero,  // = 0 
        One = 1,
        one = One,
        Two = 2,
        Three, // = 3
        Four,  // = 4
        Five = 5,
        //Six,
        Seven,
        Eight = 8,
        Nine,
        Ten = 10,
        Infinite = 255
    }
    class Program
    {
        static void Main()
        {
            EnumType digit = EnumType.Ten;

            // Enum.GetUnderlyingType() - показывает тип, который используется для представления 
            // числовых значений элементов перечисления.
            Type @enum = digit.GetType();
            Console.Write("1. Перечисление {0} состоит из элементов типа: ", @enum.Name);
            Type @const = Enum.GetUnderlyingType(@enum);
            Console.WriteLine(@const);

            // оператор typeof - возвращает экземпляр класса System.Type, который содержит информацию
            // о том типе, который был передан в качестве аргумента данного оператора.

            Console.Write("2. Перечисление EnumType состоит из элементов типа: ");

            Console.WriteLine(Enum.GetUnderlyingType(typeof(EnumType)));

            Console.ReadKey();
        }
    }

}
