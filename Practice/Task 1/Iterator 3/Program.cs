using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection uk= new UserCollection();

            uk[0] = new Element(1, 2);
            uk[1] = new Element(3, 4);
            uk[2] = new Element(5, 6);
            uk[3] = new Element(7, 8);


            IEnumerator enumerator = uk.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine((Element)enumerator.Current);
            }

            Console.WriteLine();

            foreach (var item in uk)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
