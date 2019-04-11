using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2__Static_CTOR_
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new C();
            Console.ReadKey();
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
        static A()
        {
            Console.WriteLine("Static A");
        }

    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("B");
        }
        static B()
        {
            Console.WriteLine("Static B");
        }
    }

    class C:B
    {
        public C()
        {
            Console.WriteLine("A");
        }
        static C()
        {
            Console.WriteLine("Static A");
        }
    }


}
