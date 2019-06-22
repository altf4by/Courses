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
        private static void ThreadFunc()
        {
            Console.WriteLine("ID Вторичного потока: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Вторичный поток завершился.");
        }

        static void Main()
        {
            var thread = new Thread(new ThreadStart(ThreadFunc));

            Console.WriteLine("ID Первичного потока: {0} \n", Thread.CurrentThread.GetHashCode());
            Console.WriteLine("Запуск нового потока...");

            thread.Start();
            Console.WriteLine(Thread.CurrentThread.GetHashCode());

            thread.Join(); 

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write("-");
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nПервичный поток завершился.");

            Console.ReadKey();
        }
    }

}
