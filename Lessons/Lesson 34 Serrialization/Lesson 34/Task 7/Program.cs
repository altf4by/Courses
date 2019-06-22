using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA c1 = new ClassA();
            


            ClassA c2 = c1.DeepCopy();

            Console.ReadKey();

        }
    }
}
