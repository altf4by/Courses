using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_LINQ
{
    class Program
    {
        static void Main()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);

            var query = from int n in numbers //четко указываем тип
                        select n * 2;

            foreach (var item in query)
                Console.WriteLine(item);

            Console.ReadKey();
        }

    }
}
