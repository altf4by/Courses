using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_LINQ
{
    class Program
    {
        static void Main()
        {
            var query = from x in Enumerable.Range(1, 9)
                        from y in Enumerable.Range(1, 10)
                        select new
                        {
                            X = x,
                            Y = y,
                            Product = x * y
                        };

            foreach (var item in query)
                Console.WriteLine("{0} * {1} = {2}", item.X, item.Y, item.Product);

            Console.ReadKey();
        }

    }
}
