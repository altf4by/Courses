using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Анонимные_методы
{
    public delegate int MyDelegate(int a, int b);

    class Program
    {
        static void Main()
        {
            int summand1 = 1, summand2 = 2, sum = 0;

            MyDelegate myDelegate = delegate (int a, int b) { return a + b; };

            sum = myDelegate(summand1, summand2);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            MyDelegate myDelegate2 = delegate { return 100; };
 
            Console.WriteLine(myDelegate2(2,3));

            Console.ReadKey();
        }
    }

}
