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
            Random rand = new Random();
            Tank[] russians = new Tank[5];
            Tank[] germans = new Tank[5];

            FillTeam("T-34", russians, rand);
            FillTeam("Pantera", germans, rand);
            ShowResults(Fight(russians, germans));

            Console.ReadKey();
        }

        static void FillTeam(string tankName, Tank[] team, Random rand)
        {
            for (int i = 0; i < team.Length; i++)          
                team[i] = new Tank(tankName, rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            
        }
        static bool[] Fight(Tank[] team1, Tank[] team2)
        {
            bool[] battleResults = new bool[team1.Length];
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"Состав",-15} {"Боекомплект",-20} {"Уровень брони",-20} {"Маневренность",-20} ");
            Console.WriteLine(new string('-', 75));
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < team1.Length; i++)
            {
                battleResults[i] = team1[i] > team2[i];
                Console.WriteLine($"Бой {i + 1} {new string('-', 69)}");
                Console.WriteLine($"{team1[i].Name,-20} {team1[i].Ammunition,-20} {team1[i].Armor,-20} {team1[i].Mobility,-20} ");
                Console.WriteLine($"{team2[i].Name,-20} {team2[i].Ammunition,-20} {team2[i].Armor,-20} {team2[i].Mobility,-20} ");
            }
            return battleResults;
        }
        static void ShowResults(bool[] results)
        {
            Console.WriteLine(new string('-', 75));
            int counter = 0;
            for (int i = 0; i < results.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Бой {i + 1} T-34*Pantera ");
                Console.ForegroundColor = ConsoleColor.Green;
                if (results[i])
                    counter++;
                Console.WriteLine($"Победа {(results[i] ? "T-34" : "Pantera")}");
            }
            Console.WriteLine(new string('-', 75));

            Console.WriteLine($"Победа {(counter>=3? "T-34" : "Pantera")}");
        }
    }
}
