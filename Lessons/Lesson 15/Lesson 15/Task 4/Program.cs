using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class BaseClass
    {
        public int baseNumber;

        public BaseClass()
        {
        }

        public BaseClass(int baseNumber)
        {
            this.baseNumber = baseNumber;
        }
    }
    class DerivedClass : BaseClass
    {
        public int derivedField;


        public DerivedClass(int number1, int number2):base()
        {
            // Инициализируем поле базового класса.
            baseNumber = number1;

            // Инициализируем поле производного (данного) класса.
            derivedField = number2;
        }
    }
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass(1, 2);

            Console.WriteLine(instance.baseNumber);
            Console.WriteLine(instance.derivedField);

            Console.ReadKey();
        }
    }

}
