using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Queue2
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");


            object element = queue.Peek();
            Console.WriteLine(element);

            Console.WriteLine(new string('-', 10));

            if (element is string)
            {
                Console.WriteLine(queue.Dequeue());
            }


            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue()); // Second, Third, Fourth.
            }

            Console.ReadKey();

        }
    }
}
