using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_События
{
    public delegate void EventDelegate();

    public class MyClass // класс. пораждающий событие
    {
        public event EventDelegate myEvent = null;

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

            instance.myEvent += new EventDelegate(Handler1);
            instance.myEvent += Handler2; // подписчик события (я)

            instance.InvokeEvent(); // вызов событийного метода, клик клавишей мыши, звонок будильника

            Console.WriteLine(new string('-', 20));

            instance.myEvent -= new EventDelegate(Handler2);

            instance.InvokeEvent();

            Console.ReadKey();
        }
    }

}
