using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        private static Mutex mutex = new Mutex();

        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(Function);
                thread.Name = String.Format("Поток {0}", i + 1);
                thread.Start();
            }

            Console.ReadKey();
        }

        private static void Function()
        {
            for (int i = 0; i < 2; i++)
            {
                UseResource();
            }
        }

        private static void UseResource()
        {

            mutex.WaitOne();

            Console.WriteLine("{0} вошел в защищенную область.", Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            Console.WriteLine("{0} покидает защищенную область.\r\n", Thread.CurrentThread.Name);

            mutex.ReleaseMutex();

            Thread.Sleep(1000);
        }
    }

}
