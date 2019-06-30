using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thr = new Thread(Method);
            thr.Start();
            Console.ReadKey();
        }
        static void Method()
        {
            Thread thread = Thread.CurrentThread;
            thread.Start();

        }
    }
}
