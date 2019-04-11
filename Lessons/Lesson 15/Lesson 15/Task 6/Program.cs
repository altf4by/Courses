using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class BaseClass
    {
        public int field1;
        public int field2;
        public int field3;
    }
    class DerivedClass : BaseClass
    {
        public int field4;
        public int field5;
    }
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;

            instance.field4 = 4;
            instance.field5 = 5;

            // Приведение экземпляра класса DerivedClass к базовому типу BaseClass.
            BaseClass newInstance = (BaseClass)instance; // Upcast

            Console.WriteLine(newInstance.field1);
            Console.WriteLine(newInstance.field2);
            Console.WriteLine(newInstance.field3);

            //Console.WriteLine(newInstance.field4);
            //Console.WriteLine(newInstance.field5);

            // Проверка.
            Console.WriteLine("instance Id     {0}", instance.GetHashCode());
            Console.WriteLine("newInstance Id  {0}", newInstance.GetHashCode());

            Console.ReadKey();
        }
    }

}
