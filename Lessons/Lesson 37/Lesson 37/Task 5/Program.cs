using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static WaitHandle[] events = new WaitHandle[] { new AutoResetEvent(false), new AutoResetEvent(false) };

        static Random random = new Random();

        static void Main()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Главный поток ожидает завершения ОБЕИХ задач.\n");

            ThreadPool.QueueUserWorkItem(new WaitCallback(Task1), events[0]);
            ThreadPool.QueueUserWorkItem(Task2, events[1]);

            // Ожидание пока все задачи завершаться.
            WaitHandle.WaitAll(events);

            Console.WriteLine("Обе задачи завершены (время ожидания = {0})", (DateTime.Now - dateTime).TotalMilliseconds);

            dateTime = DateTime.Now;

            Console.WriteLine("\nОжидание завершения одной из задач.");
            ThreadPool.QueueUserWorkItem(new WaitCallback(Task1), events[0]);
            ThreadPool.QueueUserWorkItem(Task2, events[1]);

            // Ожидание пока одна из задач завершится.
            int index = WaitHandle.WaitAny(events);

            Console.WriteLine("Задача {0} завершилась первой (время ожидания = {1}).", index + 1, (DateTime.Now - dateTime).TotalMilliseconds);

            Console.ReadKey();
        }

        static void Task1(Object state)
        {
            var auto = (AutoResetEvent)state;
            int time = 1000 * random.Next(2, 10);
            Thread.Sleep(time);
            Console.WriteLine("Задача 1 выполнена за {0} миллисенунд.", time);
            auto.Set();
        }

        static void Task2(Object state)
        {
            var auto = (AutoResetEvent)state;
            int time = 1000 * random.Next(2, 10);
            Thread.Sleep(time);
            Console.WriteLine("Задача 2 выполнена за {0} миллисенунд.", time);
            auto.Set();
        }
    }

}
