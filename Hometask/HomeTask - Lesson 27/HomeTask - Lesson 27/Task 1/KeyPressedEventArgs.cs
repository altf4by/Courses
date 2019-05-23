using System;

namespace Task_1
{
    public class KeyPressedEventArgs : EventArgs
    {
        public ConsoleKey Key { get; private set; }
        public KeyPressedEventArgs(ConsoleKey key)
        {
            Key = key;
        }
    }
}
