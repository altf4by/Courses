using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main()
        {
            var instance = new SomeClass();

            var thread = new Thread(instance.Method1);
            thread.Start();

            var thread2 = new Thread(instance.Method1);
            thread2.Start();

            // Delay.
            thread.Join();
            thread2.Join();
            Console.ReadKey();
        }
    }


    public class SomeClass
    {
        private Mutex mutex = new Mutex();

        public void Method1()
        {
            mutex.WaitOne();
            Console.WriteLine("Method1 Start " + Thread.CurrentThread.ManagedThreadId);
            Method2();
            mutex.ReleaseMutex();
            Console.WriteLine("Method1 End " + Thread.CurrentThread.ManagedThreadId);
        }

        public void Method2()
        {
            mutex.WaitOne();

            Console.WriteLine("Method2 Start " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            mutex.ReleaseMutex();
            Console.WriteLine("Method2 End " + Thread.CurrentThread.ManagedThreadId);
        }
    }

}
