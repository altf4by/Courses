using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket;
            do
            {
                Console.Write("Please enter the number of the ticket (6 digis): ");
                ticket = Console.ReadLine();

            } while (ticket.Length != 6);

            int[] array = new int[6];
            for (int i = 0; i < ticket.Length; i++)
            {
                array[i] = int.Parse(ticket[i].ToString());
            }

            Console.WriteLine($"Your ticket {ticket} is {((array[0] + array[1] + array[2] == array[3] + array[4] + array[5]) ? "LUCKY" : "UNlucky")}");
            Console.ReadKey(true);
        }
    }
}
