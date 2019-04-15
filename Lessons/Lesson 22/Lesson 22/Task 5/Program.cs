using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConstraints
{
    class MyClass1<T> where T : class
    {
        public T variable;
    }

    class MyClass2<T> where T : struct
    {
        public T variable;
    }

    class Program
    {
        static void Main()
        {
            MyClass1<string> instance1 = new MyClass1<string>();
            //MyClass1<int> instance1 = new MyClass1<int>();                // Ошибка.    int - структурный тип.

            MyClass2<int> instance2 = new MyClass2<int>();
            //MyClass2<string> instance2 = new MyClass2<string>();          // Ошибка.    string - ссылочный тип.

            Console.ReadKey();
        }
    }
}

