using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2__inheritance_
{
    class BaseClass
    {
        // Открытое поле.
        public string publicField = "BaseClass.publicField";

        // Закрытое поле.
        private string privateField = "BaseClass.privateField";

        // Защищенное поле.
        protected string protectedField = "BaseClass.protectedField";
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
        }
    }
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            Console.WriteLine(instance.publicField);
            

            Console.ReadKey();
        }
    }

}
