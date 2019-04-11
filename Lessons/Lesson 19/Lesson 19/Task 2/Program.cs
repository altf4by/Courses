using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    struct MyStruct
    {
        private int field;

        public int Field
        {
            get { return field; }
            set { field = value; }
        }

        public void Show()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа с вызовом конструктора по умолчанию.
            MyStruct instance = new MyStruct();

            instance.Field = 1;

            Console.WriteLine(instance.Field);

            Console.ReadKey();
        }
    }

}
