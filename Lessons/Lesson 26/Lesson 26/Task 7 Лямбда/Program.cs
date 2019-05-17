using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Лямбда
{
    public delegate int MyDelegate(int a);
    public delegate int MyDelegate2(int a, int b);


    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate;
            MyDelegate2 myDelegate2;


            myDelegate = delegate (int x) { return x * 2; }; // Лямбда-Метод 

            myDelegate = (x) => { return x * 2; };          // Лямбда-Оператор.

            myDelegate = x => x * 2;                        // Лямбда-Выражение.

            myDelegate2 = (x, y) => x * y;

            double result = myDelegate(4);
            Console.WriteLine(result);

            Console.WriteLine(myDelegate2);

            Console.ReadKey();
        }
    }

}
