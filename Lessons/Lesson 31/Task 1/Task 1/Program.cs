using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_31
{

    class MyClass
    {
    }

    class Program
    {
        static void Main()
        {
            var my = new MyClass();
            Type type;

            type = my.GetType();
            Console.WriteLine("1й способ: " + type);

            type = Type.GetType("Task_1.MyClass");
            Console.WriteLine("2й способ: " + type);

            type = typeof(MyClass);
            Console.WriteLine("3й способ: " + type);

            Console.ReadKey();
        }
    }

}
