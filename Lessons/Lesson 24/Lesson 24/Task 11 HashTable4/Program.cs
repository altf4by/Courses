using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_HashTable4
{
    public class Fish
    {
        public string name;

        public Fish(string name)
        {
            this.name = name;
        }
    }

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
