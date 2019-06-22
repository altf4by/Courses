using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread mtl = new MyThread("Мой поток");

            Thread.Sleep(1000);

            Console.WriteLine("Прерывание выполнения потока.");
            mtl.thrd.Abort(100);

            mtl.thrd.Join();
            Console.WriteLine("Основной поток завершен.");

            Console.ReadKey();

        }
    }

    class MyThread
    {
        public Thread thrd;

        public MyThread(string name)
        {
            thrd = new Thread(new ThreadStart(this.run));
            thrd.Name = name;
            thrd.Start();
        }

        void run()
        {
            try
            {
                Console.WriteLine(thrd.Name + " стартовал.");

                for (int i = 1; i <= 1000; i++)
                {
                    Console.Write(i + " ");
                    if ((i % 10) == 0)
                    {
                        Console.WriteLine();
                        Thread.Sleep(450);
                    }
                }
                Console.WriteLine(thrd.Name + " завершился нормально");
            }
            catch (ThreadAbortException exc)
            {
                Console.WriteLine(
                "Выполнение потока прервано, код завершения = " +
                                    exc.ExceptionState);
            }
        }
    }

}
