using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Анонимные_методы
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello world!"); };

            //MyDelegate myDelegate = new MyDelegate(delegate { Console.WriteLine("Hello world!"); });

            myDelegate();

            Console.ReadKey();
        }
    }

}
