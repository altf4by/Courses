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
            RailwayStation rw = new RailwayStation();

            rw.AddUserTrain();

            rw.Add(new Train("Homel", 1.ToString(), new DateTime(2019, 04, 08, 12, 35, 00)));
            rw.Add(new Train("Hrodna", 2.ToString(), new DateTime(2019, 04, 08, 14, 17, 00)));

            Console.WriteLine();
            int counter = 0;
            do
            {
                Console.Write("Please, enter the number of the train to display info: ");
                Console.WriteLine(rw[Console.ReadLine()].Display());
                counter++;
            } while (counter!=3);

            

            Console.ReadKey(true);
        }
    }
}
