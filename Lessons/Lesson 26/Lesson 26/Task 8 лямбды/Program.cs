using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_лямбды
{
    delegate Delegate2 Delegate1();
    delegate void Delegate2();


    class Program
    {
        public static Delegate2 Method1()
        {
            return new Delegate2(Method2);
        }

        public static void Method2()
        {
            Console.WriteLine("Hello world!");
        }

        static void Main()
        {
            Delegate1 delegate1 = new Delegate1(Method1);

            delegate1().Invoke();

            Console.ReadKey();
        }
    }

}
