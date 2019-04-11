using System;
using A.B;
using ABCD = A.B.C.D.DDD;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BB bb = new BB();
            Console.ReadKey();
            DDD ddd = new DDD();
            //ABCD.DDD d = new ABCD.DDD();
            //ABCD::DDD d2 = new ABCD.DDD(); - использование псевдонимов пространств имен

            ABCD d2 = new ABCD(); // определение псевдонимов типов

        }
    }

    class DDD
    {

    }
}

namespace A
{
    class MyClass2
    {

    }
}

namespace A
{
    namespace B
    {
        namespace C
        {
            namespace D
            {
                class DDD
                {

                }
            }
        }
        class BB
        {

        }
    }
    class MyClass
    {
        static void MyMethod()
        {
            Console.ReadKey();
        }
    }
}
