using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class KeyBoardController
    {
        public event EventHandler<KeyPressedEventArgs> KeyPressed;
        public event EventHandler<CounterEventArgs> StopKeyPressed;

        public void RunKeyPressed(ConsoleKey key)
        {
            EventHandler<KeyPressedEventArgs> keyPresed = KeyPressed;

            if (keyPresed != null)
            {
                keyPresed(this, new KeyPressedEventArgs(key));
            }
        }

        public void RunStopKeyPressed(int counter)
        {
            EventHandler<CounterEventArgs> counterInfo = StopKeyPressed;
            if (counterInfo != null)
            {
                counterInfo(this, new CounterEventArgs(counter));
            }
        }
    }   
}
