using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new B();
            A a3 = new C();


            a1.M();
            a2.M();
            a3.M();

            Console.ReadKey();
        }
    }
    class A
    {
        public virtual void M()
        {
            Console.WriteLine("M from A");
        }
    }

    class B:A
    {
        public new virtual void M()
        {
            Console.WriteLine("M from B");
        }
    }

    class C : B
    {
        public override void M()
        {
            Console.WriteLine("M from C");
        }
    }

}
