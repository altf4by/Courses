using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            new A().Method();
            new A().Method2();
            new A().SomeMethod(4,5);
            ExtensionForAType.SomeMethod(new A(), 4, 5);
            Console.WriteLine(5.MyEquals(7));
        }
    } 

    static class ExtensionForAType
    {
        public static int SomeMethod(this A a, int x, int y)
        {
            return x + y;
        }
        public static bool MyEquals (this int a, int x)
        {
            return a == x;
        }
    }

    partial class A
    {
        public void Method()
        {
            Console.WriteLine("Call from first part of the class");
        }

        public int SomeMethod( int x, int y)
        {
            return x + y;
        }

    }


}
