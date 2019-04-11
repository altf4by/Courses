using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(0);

            if (c)
                Console.WriteLine("true");
            else Console.WriteLine("false");
            Console.ReadKey();
        }
    }
    class Counter
    {
        int _count;
        public Counter(int count)
        {
            _count = count;
        }

        public static bool operator true(Counter counter)
        {
            return counter._count != 0;
        }
        public static bool operator false(Counter counter)
        {
            return counter._count == 0;
        }

    }
}
