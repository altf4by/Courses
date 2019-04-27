using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_HashTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new Hashtable();

            emailLookup["hop@oso.com"] = "Bishop, Scott";
            emailLookup["ess@oso.com"] = "Hell, Christian";
            emailLookup["ump@oso.com"] = "Jump, Dan";

            foreach (object name in emailLookup)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(new string('-', 20));

            foreach (DictionaryEntry name in emailLookup)
            {
                Console.WriteLine(name.Value);
            }

            Console.WriteLine(new string('-', 20));

            foreach (object name in emailLookup.Values)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();

        }
    }
}
