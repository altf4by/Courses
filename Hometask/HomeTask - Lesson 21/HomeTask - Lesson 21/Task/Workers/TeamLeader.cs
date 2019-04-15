using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.House_parts;

namespace Task.Workers
{
    class TeamLeader : Worker, IWorker
    {
        public static bool IsPartFinished { get; set; }
        public TeamLeader(string name) : base(name) { }


        public new void Work(IPart housePart)
        {
            if (housePart is Roof && (housePart as Roof).IsReady)
            {
                DrawHouse();
                return;
            }
            else
            {
                if (housePart.IsReady)
                {
                    Console.WriteLine("*****{0} is {1}% COMPLETED. WE CAN BUILD NEXT PART.*****", housePart.GetType().Name.ToUpper(), housePart.PercentReady);
                    IsPartFinished = true;
                }
                else
                    Console.WriteLine("{0} is not ready! Let's work, Guys!\n", housePart.GetType().Name);
            }

           
        }
        public void DrawHouse()
        {
            Console.WriteLine("     /\\");
            Console.WriteLine("    /  \\");
            Console.WriteLine("   /    \\");
            Console.WriteLine("  /      \\ ");
            Console.WriteLine(" /--------\\ ");
            Console.WriteLine("/ |      | \\ ");
            Console.WriteLine("  |      |");
            Console.WriteLine("  |      |");
            Console.WriteLine("  | ____ |");
        }
    }
}
