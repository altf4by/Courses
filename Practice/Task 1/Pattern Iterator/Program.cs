using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Agregate agregate = new ConcreteAgregate();

            agregate[0] = "Element A";
            agregate[1] = "Element B";
            agregate[2] = "Element C";
            agregate[3] = "Element D";

            Iterator iterator = agregate.CreateIterator();

            Console.WriteLine("First element in Collection: ");

            object element = iterator.First();
            Console.WriteLine(element);

            Console.WriteLine(new string('-',25));

            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
            Console.ReadKey();
        }
    }
}
