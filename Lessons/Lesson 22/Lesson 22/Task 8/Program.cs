using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConstraints
{
    interface IInterface { /* ... */ }
    interface IInterface<U> : IInterface { /* ... */ }

    class Derived : IInterface, IInterface<object> { /* ... */ }

    class Derived2 : IInterface<object> { /* ... */ }

    class MyClass<T> where T : IInterface, IInterface<object> { /* ... */ }

    class MyClass2<T> where T : IInterface<object> { /* ... */ }


    class Program
    {
        static void Main()
        {
            // В качестве аргумента типа подходит Derived, т.к., он наследуется от обоих интерфейсов.
            MyClass<Derived> my1 = new MyClass<Derived>();
            //MyClass<IInterface> my1 = new MyClass<IInterface>();   // Ошибка.

            //  Аргумент типа подходит, т.к., IInterface<object> наследуется от IInterface
            MyClass<IInterface<object>> my2 = new MyClass<IInterface<object>>();

            MyClass2<Derived> my3 = new MyClass2<Derived>();
            MyClass2<Derived2> my4 = new MyClass2<Derived2>();
            MyClass2<IInterface<object>> my5 = new MyClass2<IInterface<object>>();

            Console.ReadKey();
        }
    }
}

