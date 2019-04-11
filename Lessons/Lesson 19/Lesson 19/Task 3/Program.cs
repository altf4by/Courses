using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    struct MyStruct
    {
        public int field;

        // Конструкторы по умолчанию нельзя задавать явно.
        //public MyStruct()
        //{
        //}

        // Если в структуре имеется пользовательский конструктор, то требуется в нем инициализировать все поля.
        public MyStruct(int value)
        {
            Console.WriteLine("Constructor");
            this.field = value;
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа с вызовом конструктора по умолчанию.
            MyStruct instance = new MyStruct();

            Console.WriteLine(instance.field);

            Console.ReadKey();
        }
    }

}
