using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Semaphore semaphore;
        static Mutex mutex;
        static string path = @"C:\log.txt";


        static void Main(string[] args)
        {
            semaphore = new Semaphore(2, 4, "MySemaphore");
            mutex = new Mutex();
            Console.Write("Progress: ");

            for (int i = 0; i < 10; i++)
                new Thread(GetAccess).Start(new ThrdState(i, new AutoResetEvent(false)));

            Thread.Sleep(2000);
            semaphore.Release(2);
            Console.ReadKey();
        }

        static void GetAccess(object state)
        {
            if (!(state is ThrdState))
                throw new ArgumentException(nameof(state));

            semaphore.WaitOne();
            mutex.WaitOne();

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Thread - {0} PROVIDED access to the file.", ((ThrdState)state).Number);
            }
            mutex.ReleaseMutex();
            Thread.Sleep(1000);

            mutex.WaitOne();

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Thread - {0} RELEASED access to the file.", ((ThrdState)state).Number);
            }
            mutex.ReleaseMutex();

            ((ThrdState)state).ResetEvent.Set();

            semaphore.Release();
            Console.Write("*");
        }
    }
}
