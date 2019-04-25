using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            foreach (string element in UserCollection.Power())
                Console.WriteLine(element);

            Console.WriteLine(new string('-', 12));

            //----------------------
            // Так работает foreach.

            IEnumerable enumerable = UserCollection.Power();

            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                String element = enumerator.Current as String;

                Console.WriteLine(element);
            }

            Console.ReadKey();
        }

    }
    class UserCollection
    {
        public static IEnumerable Power()
        {
            yield return "Hello world!";
        }
    }

}
