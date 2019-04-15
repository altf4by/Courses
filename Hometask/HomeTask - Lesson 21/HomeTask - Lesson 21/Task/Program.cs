using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.House_parts;
using Task.Workers;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team(new Worker("Sam"), new Worker("Bill"), new Worker("John"), new Worker("Tom"), new Worker("Mack"), new TeamLeader("BOSS"));

            team.StartWork(house);






            Console.ReadKey(true);
        }
    }
}
