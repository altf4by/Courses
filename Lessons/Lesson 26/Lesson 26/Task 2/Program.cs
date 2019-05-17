using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_2
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Строку вывел метод сообщенный с делегатом.");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);

            myDelegate.Invoke();

            myDelegate();

            Console.ReadKey();
        }
    }

}
