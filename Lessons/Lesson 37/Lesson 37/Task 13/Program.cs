using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            var myDelegate = new Action(Method);

            var callback = new AsyncCallback(HandleCompletion);


            myDelegate.BeginInvoke(callback, "Hello world");

            Console.WriteLine("Первичный поток продолжает работать.");

            Console.ReadKey();
        }

        static void Method()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nАсинхронный метод запущен.");
            Console.WriteLine("\nВторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(50);
                Console.Write(".");
            }

            Console.WriteLine("Асинхронная операция завершена.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void HandleCompletion(IAsyncResult asyncResult)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Callback метод. Thread Id {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Информация связанная с асинхронной операцией - " + asyncResult.AsyncState);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

}
