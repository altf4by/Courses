using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alpha a = new Alpha();
            Console.WriteLine("Выполнение команды A.show()");

            a.Show();
            Console.WriteLine();

            Bravo b = new Bravo();
            Console.WriteLine("Выполнение команды B.Hello()");
            b.Hello();
            Console.WriteLine();

            Console.WriteLine("Выполнение команды B.Hi()");
            b.Hi();
            Console.WriteLine();

            Console.WriteLine("Выполнение команды B.show()");

            b.Show();
            Console.WriteLine();


            a = b;

            a.Hello();
            a.Hi();
            a.Show();

            Console.ReadKey(true);
        }
    }

    class Alpha
    {
        public virtual void Hi()
        {
            Console.WriteLine("Метод Hi() из класса Alpha");
        }
        public void Hello()
        {
            Console.WriteLine("Метод Hello() из класса Alpha");
        }

        public void Show()
        {
            Hi();
            Hello();
        }
    }
    class Bravo : Alpha
    {
        public new void Hello()
        {
            Console.WriteLine("Метод Hello() из класса Bravo");
        }
        public override void Hi()
        {
            Console.WriteLine("Метод Hi() из класса Bravo");
        }
    }
}
