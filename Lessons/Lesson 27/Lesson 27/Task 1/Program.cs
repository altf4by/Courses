using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = () => Console.WriteLine("!!!!");

            action();

            Action<int, string> action2 = (x, str) => Console.WriteLine("{0}: {1}", x, str);

            Func<int> func = () => 5;

            Func<string, int> func2 = (str) => str.Length;

            Console.ReadKey();
        }
    }
}
