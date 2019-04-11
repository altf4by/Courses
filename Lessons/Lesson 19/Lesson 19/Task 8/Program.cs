using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 v = 5;
            Object o = v;
            v = 123;
            Console.WriteLine(v + ", " + (Int32)o);
            
        }
    }
}
