using System;

namespace Task_2
{
    public class SomeEventArgs : EventArgs
    {
        public int MyProperty { get; set; }
        public SomeEventArgs(int input)
        {
            MyProperty = input;
        }

    }
}