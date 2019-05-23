using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 67;

            Action<int> action = (x) => Console.WriteLine(x + i); // замыкание (замыкаем переменную i)

            action(3);

            MyClass myClass = new MyClass();
            myClass.i = i;
            myClass.Action(3);   // аналогичный код

            Console.ReadKey();
        }
    }
    class MyClass
    {
        public int i;

        public void Action(int x)
        {
            Console.WriteLine(x+i);
        }
    }
}
