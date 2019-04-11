using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    struct MyStruct
    {
        public int field;

        // Статический конструктор всегда отрабатывает первым.
        static MyStruct()
        {
            Console.WriteLine("Static Constructor");
        }

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
            // Не запускать!!!	
            MyStruct instance = new MyStruct { field = 0 };

            Console.WriteLine(instance.field);

            Console.ReadKey();
        }
    }

}
