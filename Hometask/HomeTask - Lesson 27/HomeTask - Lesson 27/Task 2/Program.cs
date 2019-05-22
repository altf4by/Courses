using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificator = new ClassWithNotificationEvent();

            notificator.Notify += (sender, message) => Console.WriteLine(message);

            notificator.Notify += (sender, message) => Console.WriteLine("****" + message + "****");

            notificator.Notify += (sender, message) => Console.WriteLine("**-**" + message + "**-**");

            notificator.NewMessageAppeared("New message");
        }
    }

    public class ClassWithNotificationEvent
    {
        public event EventHandler Notify;

        public void NewMessageAppeared(string stringArg, int intArg)
        {
            Notify(this, new MyEventArgs(stringArg, intArg));
        }
    }

    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(string stringArg, int intArg)
        {
            StringArg = stringArg;
            IntArg = intArg;
        }

        public string StringArg;

        public int IntArg;
    }
}
