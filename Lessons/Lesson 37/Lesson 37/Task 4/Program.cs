using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static EventWaitHandle manual = null;

        static void Main()
        {

            manual = new EventWaitHandle(false, EventResetMode.ManualReset, "GlobalEvent::GUID");

            Thread thread = new Thread(Function);
            thread.IsBackground = true;
            thread.Start();

            Console.WriteLine("Нажмите любую клавишу для начала работы потока.");
            Console.ReadKey();


            manual.Set();

            Console.ReadKey();
        }

        static void Function()
        {
            manual.WaitOne();

            while (true)
            {
                Console.WriteLine("Hello world!");
                Thread.Sleep(300);
            }
        }
    }

}
