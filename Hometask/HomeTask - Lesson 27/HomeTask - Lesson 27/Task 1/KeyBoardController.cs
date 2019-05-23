using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class KeyBoardController
    {
        public void Start()
        {
            ConsoleKey key;
            int counter = 0;

            Console.WriteLine("Start printing, till \".\" not pressed");

            do
            {
                key = Console.ReadKey().Key;
                counter++;

                KeyPressed?.Invoke(this, key);
            } while (key != ConsoleKey.OemPeriod);

            EventHandler<CounterEventArgs> CounterInfo = StopKeyPressed;
            if (CounterInfo != null)
            {
                CounterInfo(this, new CounterEventArgs(counter));
            }
            //StopKeyPressed?.Invoke(this, counter);
        }

        public event EventHandler<ConsoleKey> KeyPressed;
        public event EventHandler<CounterEventArgs> StopKeyPressed;
    }

    public class CounterEventArgs : EventArgs
    {
        public int counter = 0;
        public CounterEventArgs(int count)
        {
            counter = count;
        }
    }
}
