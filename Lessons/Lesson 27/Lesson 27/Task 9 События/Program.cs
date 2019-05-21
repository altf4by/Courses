using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_События
{
    class Program
    {
        static void handler(object source, EventArgs arg)
        {
            Console.WriteLine("Событие произошло.");
            Console.WriteLine("Источником является класс " +
            source + ".");
        }

        static void Main()
        {
            MyEvent evt = new MyEvent();

            evt.SomeEvent += new EventHandler(handler);

            evt.OnSomeEvent();

            Console.ReadLine();
        }
    }

    class MyEvent
    {
        public event EventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if (SomeEvent != null)
            {
                SomeEvent(this, EventArgs.Empty);
            }
        }
    }

}
