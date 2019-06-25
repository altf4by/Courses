using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_8
{
    public class Program
    {
        private static Semaphore pool;

        private static void Work(object number)
        {
            pool.WaitOne();

            Console.WriteLine("Поток {0} занял слот семафора.", number);
            Thread.Sleep(1000);
            Console.WriteLine("Поток {0} -----> освободил слот.", number);

            pool.Release();
        }

        public static void Main()
        {

            pool = new Semaphore(2, 4, "MySemafore65487563487");

            for (int i = 1; i <= 8; i++)
            {
                Thread thread = new Thread(Work);
                thread.Start(i);
            }
            Thread.Sleep(2000);
            pool.Release(1);


            Console.ReadKey();
        }
    }

}
