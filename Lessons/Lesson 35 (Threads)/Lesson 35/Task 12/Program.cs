using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread mtl = new MyThread("Мой поток");

            Thread.Sleep(1000);

            Console.WriteLine("Прерывание выполнения потока.");
            mtl.thrd.Abort(0);

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
            Console.WriteLine(thrd.Name + " стартовал.");

            for (int i = 1; i <= 1000; i++)
            {
                try
                {
                    Console.Write(i + " ");
                    if ((i % 10) == 0)
                    {
                        Console.WriteLine();
                        Thread.Sleep(450);
                    }
                }


                catch (ThreadAbortException exc)
                {
                    if ((int)exc.ExceptionState == 0)
                    {
                        Console.WriteLine(
                                 "Прерывание отменено! Код завершения = " +
                                  exc.ExceptionState);
                        Thread.ResetAbort();
                    }
                    else
                        Console.WriteLine(
                            "Выполнение потока прервано, код завершения = "
                                  + exc.ExceptionState);

                }
            }
            Console.WriteLine(thrd.Name + " завершился нормально");
        }
    }

}
