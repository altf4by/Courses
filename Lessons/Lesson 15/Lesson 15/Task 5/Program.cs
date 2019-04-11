using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class BaseClass
    {
        public int baseNumber;

        // Конструктор по умолчанию.
        public BaseClass()
        {
        }

        // Пользовательский конструктор.
        public BaseClass(int number)
        {
            this.baseNumber = number;
        }
    }

    class DerivedClass : BaseClass
    {
        public int derivedField;

        // Конструктор по умолчанию.
        public DerivedClass()
        {
        }

        // Пользовательский конструктор.
        // Вызывается пользовательский конструктор базового класса, при этом не нужно, 
        // присваивать значения, унаследованным членам в конструкторе производного класса.
        public DerivedClass(int number1, int number2)
            : base(number1)
        {
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
