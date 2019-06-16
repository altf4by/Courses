using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_2__Deshifrator_
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\test.txt";
            string path2 = @"C:\test2.txt";

            List<string> strings = new List<string>();
            string pronouns = "at |on |in |with |after |before |about |of |for |to |by |of|up |down ";

            var regex = new Regex(pronouns);

            foreach (var str in File.ReadAllLines(path))
                strings.Add(Regex.Replace(str, pronouns, "Hello "));

            File.WriteAllLines(path2, strings);

            Console.ReadKey();
        }
    }
}
