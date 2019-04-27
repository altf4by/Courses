using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_List1
{
    class Program
    {
        static void Main(string[] args)
        {
            var links = new LinkedList<string>();


            List<int> result = new List<int>();

            LinkedListNode<string> first = links.AddFirst("First");
            LinkedListNode<string> last = links.AddLast("Last");
            LinkedListNode<string> afterlast = links.AddAfter(last, "After last");

            LinkedListNode<string> second = links.AddBefore(last, "Second");
            links.AddAfter(second, "Third");

            foreach (string s in links)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();

        }
    }
}
