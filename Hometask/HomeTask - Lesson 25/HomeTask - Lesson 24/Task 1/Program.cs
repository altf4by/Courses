using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            Console.WriteLine("Add Last: ");
            foreach (Element<int> element in list)
                Console.Write("{0} ",element.ToString());

            list.AddAfterByValue(1, 5);

            Console.WriteLine();
            Console.WriteLine("Add After By Value: ");

            foreach (Element<int> element in list)
                Console.Write("{0} ", element.ToString());

            list.AddAfterByPosition(1, 100);

            Console.WriteLine("\nAdd After By Position: ");

            foreach (Element<int> element in list)
                Console.Write("{0} ", element.ToString());

            Console.ReadKey();
        }
    }
}
