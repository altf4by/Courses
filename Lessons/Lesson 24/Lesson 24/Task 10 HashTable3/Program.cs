using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_HashTable3
{
    class Program
    {
        static void Main(string[] args)
        {
            var duplicates = new Hashtable();

            duplicates["First"] = "1st";
            duplicates["First"] = "the first";

            Console.WriteLine(duplicates.Count);

            Console.ReadKey();

        }
    }
}
