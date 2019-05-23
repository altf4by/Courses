using System;

namespace Task_1
{
    public class CounterEventArgs : EventArgs
    {
        public int Counter { get; private set; }
        public CounterEventArgs(int count)
        {
            Counter = count;
        }
    }
}
