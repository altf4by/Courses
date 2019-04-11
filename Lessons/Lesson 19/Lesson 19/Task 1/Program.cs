using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    struct MyStruct
    {
        public int field;
    }

    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа, без вызова конструктора.
            MyStruct instance;

            instance.field = 1; // Закомментировать.

            // Попытка вывода значения неинициализированного поля приведет к ошибке.
            Console.WriteLine(instance.field);

            Console.ReadKey();
        }
    }

}
