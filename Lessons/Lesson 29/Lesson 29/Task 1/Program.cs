using System;

using ClassLibrary1;

namespace Task_1
{
    class MyClass : MyPublicClass
    {

        public void MyMethod()
        {
            this.InternalProtectedMethod();
        }
    }


    class Program
    {
        static void Main()
        {
            // 1.

            MyPublicClass instanceA = new MyPublicClass();
            instanceA.PublicMethod();
            //instanceA.InternalMethod();             // Недоступен.
            //instanceA.InternalProtectedMethod();    // Недоступен.

            //MyInternalClass instance = new MyInternalClass();   // Недоступен.


            Console.WriteLine(new string('-', 20));


            // 2.

            MyClass instance = new MyClass();
            instance.PublicMethod();
            instance.MyMethod();     // Вызов InternalProtectedMethod().
                                     //instance.InternalMethod();     // Недоступен.


            Console.ReadKey();
        }

    }
}
