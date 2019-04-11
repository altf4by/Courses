using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class ClassA { /* ... */ }

    class ClassB : ClassA { /* ... */ }

    class Program
    {
        static void Main()
        {
            ClassB b = new ClassB();
            ClassA a = null;

            //--------------------------------------------- is --------------------------------------------- 
            // Оператор is - проверяет совместимость объекта с заданным типом. 
            // Если предоставленный объект может быть приведен к предоставленному типу не вызывая исключение,
            // выражение is принимает значение true.

            if (b is ClassA)
            {
                a = (ClassA)b;
            }
            else
            {
                a = null;
            }

            //--------------------------------------------- as---------------------------------------------  


            a = b as ClassA;

            Console.ReadKey();
        }
    }

}
