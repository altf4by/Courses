using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{


    class Program
    {
        static void Main()
        {
            var duplicates = new Hashtable();

            var key1 = new Fish("Herring");
            var key2 = new Fish("Herring");

            duplicates[key1] = "Hello";
            duplicates[key2] = "Hello2";


            Console.WriteLine(duplicates.Count);
            Console.ReadKey();
        }
    }
}
