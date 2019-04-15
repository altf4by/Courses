using System;
using Task.House_parts;

namespace Task.Workers
{
    class TeamLeader : Worker, IWorker
    {
        public static bool IsPartFinished { get; set; }

        public TeamLeader(string name) : base(name) { }


        void IWorker.Work(IPart housePart)
        {            
            {
                if (housePart.IsReady)
                {
                    Console.WriteLine("*****{0} is {1}% COMPLETED. WE CAN START UP NEXT PART.*****", housePart.GetType().Name.ToUpper(), housePart.PercentReady);
                    if (housePart is Roof)
                    {
                        DrawHouse();
                        return;
                    }
                    IsPartFinished = true;
                }
                else
                {
                    Console.WriteLine("{0} is not ready! Let's work, Guys!\n", housePart.GetType().Name);
                    IsPartFinished = false;
                }
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
