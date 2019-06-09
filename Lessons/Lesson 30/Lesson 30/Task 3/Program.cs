using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var spisok = new List<string>(5);

            for (int i = 0; i < 5; i++)
            {
                spisok.Add("number " + (i + 1));
            }

            spisok.ForEach(Console.WriteLine);

            foreach (var item in spisok.FindAll(new Predicate<string>(x => x[x.Length - 1] == '5' || x[x.Length - 1] == '3')))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            
        }
    }

}
