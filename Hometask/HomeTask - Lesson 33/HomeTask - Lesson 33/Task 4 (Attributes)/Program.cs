using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4__Attributes_
{
    class Program
    {
        static void Main(string[] args)
        {
            var sp = new SuperProject();

            sp.OldVersion();
            sp.NewVersion();
            sp.OldVersion2();

            Console.ReadKey();
        }
    }
}
