using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.Ducks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Lake lake = new Lake();

            lake.Add(new SimpleDuck());
            lake.Add(new ExoticDuck());
            lake.Add(new WoodDuck());
            lake.Add(new RubberDuck());

            lake[0].ChangeFlyBehavoir();

            lake.Display();

            Console.ReadKey();
        }
    }
}
