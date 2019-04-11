using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class BaseClass
    {
        public virtual void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        // Переопределение метода базового класса.

        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            // UpCast
            BaseClass instanceUp = instance as BaseClass;
            instanceUp.Method();

            // DownCast
            DerivedClass instanceDown = instanceUp as DerivedClass;
            instanceDown.Method();

            Console.ReadKey();
        }
    }

}
