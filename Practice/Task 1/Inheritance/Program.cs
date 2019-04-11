using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass('a',5);
            Base b;

            b = a;

            b.Show();
            a.Display();

            ((MyClass)b).Display();
        }
    }

    class Base
    {
        public int number;
        public Base(int n)
        {
            number = n;
        }
        public Base(Base obj)
        {
            number = obj.number;
        }
        public void Show()
        {
            Console.WriteLine($"Поле number: {number}");
        }
    }
    class MyClass:Base
    {
        public char symbol;
        public MyClass(char s, int n):base(n)
        {
            symbol = s;
        }
        public MyClass(MyClass obj):base(obj)
        {
            symbol = obj.symbol;
        }

        public void Display()
        {
            Console.WriteLine($"Поле symbol: {symbol}");
        }
    }

}
