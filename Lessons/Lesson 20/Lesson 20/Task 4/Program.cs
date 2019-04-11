using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
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
            // Enum.GetValues() - возвращает экземпляр System.Array, при этом каждому элементу массива 
            // будет соответствовать член указанного перечисления.

            // Помещаем в массив элементы перечисления.
            Array array = Enum.GetValues(typeof(EnumType));

            // Получаем информацию о количестве элементов в массиве.
            Console.WriteLine("Это перечисление содержит {0} членов \n", array.Length);

            // Вывод на экран всех элементов перечисления
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Имя константы: {0}, значение {0:D}", array.GetValue(i));
            }


            Array array1 = Array.CreateInstance(typeof(EnumType), 5);
            array1.SetValue(EnumType.Two,0);

            Console.ReadKey();
        }
        static void MMM(Type type, int length)
        {
            Array array = Array.CreateInstance(type, length);
        }

    }

}
