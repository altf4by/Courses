using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new Hashtable();

            emailLookup.Add("hop@oso.com", "Bishop, Scott");
            //emailLookup.Contains(); проверка на наличие

            //emailLookup.Add("hop@oso.com", "Bishop, Scott2");


            emailLookup["s. hop@oso.com"] = "Bishop, Scott";

            emailLookup["hop@oso.com"] = "-------------";


            Console.WriteLine(emailLookup["hop@oso.com"]);
            Console.WriteLine(emailLookup["s. hop@oso.com"]);

        }
    }
}
