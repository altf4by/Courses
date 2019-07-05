using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        static void Main(string[] args)
        {
            var signal = new ManualResetEvent(false);

            Task.Run(() => Console.WriteLine("Hello from the pool!"));
            ThreadPool.QueueUserWorkItem(notUsed => Console.WriteLine("Hello"));

            new Thread(() =>
            {
                Console.WriteLine("Waiting for signal");     
                Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
                signal.WaitOne();
                signal.Dispose();
                Console.WriteLine("Got Signal");
                Console.ReadKey();

            }).Start();
            Thread.Sleep(2000);
            signal.Set();


        }
    }


}
