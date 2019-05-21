using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_События
{
    public delegate void EventDelegate();

    public class MyClass
    {
        EventDelegate myEvent = null;

        public event EventDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }

    class Program
    {
        static private void Handler1()
        {
            Console.WriteLine("Обработчик события 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Обработчик события 2");
        }

        static void Main()
        {
            MyClass instance = new MyClass();

            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += new EventDelegate(Handler2);

            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            instance.MyEvent -= new EventDelegate(Handler2);
            instance.InvokeEvent();

            Console.ReadKey();
        }
    }
}

