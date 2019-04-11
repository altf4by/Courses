using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class AbstractClass
    {
        public AbstractClass()
        {
            Console.WriteLine("1 AbstractClass()");

            this.AbstractMethod();

            Console.WriteLine("2 AbstractClass()");
        }

        public abstract void AbstractMethod();
    }

    class ConcreteClass : AbstractClass
    {
        string s = "FIRST";

        public ConcreteClass()
        {
            Console.WriteLine("3 ConcreteClass()");
            s = "SECOND";
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Реализация метода AbstractMethod() в ConcreteClass  {0}", s);
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClass();

            Console.WriteLine(new string('-', 55));

            instance.AbstractMethod();

            Console.ReadKey();
        }
    }

}
