using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            AutoResetEvent auto = new AutoResetEvent(false);
            WaitOrTimerCallback callback = new WaitOrTimerCallback(CallbackMethod);



            var waitHandle = ThreadPool.RegisterWaitForSingleObject(auto, callback, null, 1000, false);
            //var waitHandle = ThreadPool.RegisterWaitForSingleObject(auto, callback, null, Timeout.Infinite, true);

            Console.WriteLine("S - сигнал, Q - выход");

            while (true)
            {
                string operation = Console.ReadKey(true).KeyChar.ToString().ToUpper();

                if (operation == "S")
                {
                    auto.Set();
                }
                if (operation == "Q")
                {
                    waitHandle.Unregister(auto);
                    break;
                }
            }
            Console.ReadKey();
        }

        static void CallbackMethod(object state, bool timedOut)
        {
            Console.WriteLine("Signal");
        }
    }

}
