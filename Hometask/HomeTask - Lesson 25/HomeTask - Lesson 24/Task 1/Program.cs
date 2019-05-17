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
            list.AddLast(4);

            Console.WriteLine("Add Last: ");
            foreach (Element<int> element in list)
                Console.Write("{0} ",element.ToString());

            Console.WriteLine("\nAdd After By Value: ");

            list.AddAfterByValue(1, 5);
            foreach (Element<int> element in list)
                Console.Write("{0} ", element.ToString());

            Console.WriteLine("\nAdd After By Position: ");

            list.AddAfterByPosition(1, 100);
            foreach (Element<int> element in list)
                Console.Write("{0} ", element.ToString());

            Console.WriteLine("\nDELETE By Value: ");

            list.Delete(200);
            foreach (Element<int> element in list)
                Console.Write("{0} ", element.ToString());



            Console.ReadKey();
        }
    }
}
