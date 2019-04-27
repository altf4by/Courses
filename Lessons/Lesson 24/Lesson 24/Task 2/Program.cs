using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            list.Add("Hello");
            list.Add("Goodbye");

            // 1.
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // 2.
            IEnumerator enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            // 3.
            foreach (string item in list)
            {
                //  Never do this!!!
                //list.Remove(item);
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
