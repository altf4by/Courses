using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_5_Объекты_ядра_виндовс
{
    class Program
    {

        private static readonly Mutex Mutex1 = new Mutex(false );

        static void Main()
        {
            var threads = new Thread[5];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Function)
                {
                    Name = i.ToString()
                };
                threads[i].Start();
            }


            Console.ReadKey();
        }

        static void Function()
        {
            bool myMutex = Mutex1.WaitOne();

            Console.WriteLine("Поток {0} зашел в защищенную область.", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Поток {0}  покинул защищенную область.\n", Thread.CurrentThread.Name);
            Mutex1.ReleaseMutex();
        }
    }

}
