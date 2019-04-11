using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    struct MyStruct
    {
        public static int Field
        {
            get;
            set;
        }

        public static void Show()
        {
            Console.WriteLine(Field);
        }
    }

    class Program
    {
        static void Main()
        {
            // Инициализация статических полей необязательна.
            //MyStruct.Field = 1;

            MyStruct.Show();

            Console.ReadKey();
        }
    }

}
