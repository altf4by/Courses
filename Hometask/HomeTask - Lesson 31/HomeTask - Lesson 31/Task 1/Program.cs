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
            var query1 = Formula1.GetContructorChampions()
                .SelectMany(team => team.Years, (team, year) => new { Year = year, team.Name })
                .Join(Formula1.GetChampions().SelectMany(racer => racer.Years, (racer, year) => new { Year = year, Name = racer.LastName }),
                team => team.Year,
                champ => champ.Year,
                (champ, team) => new { champ.Year, champ.Name, TeamName = team.Name }).Take(10);


            var query2 = Formula1.GetChampions().SelectMany(racer => racer.Years, (racer, year) => new { year, racer.LastName }).
                Join(Formula1.GetContructorChampions().SelectMany(team => team.Years, (team, year) => new { Team = team.Name, year }),
                team => team.year,
                champ => champ.year,
                (champ, team) => new { Year = team.year, TeamName = team.Team, ChampName = champ.LastName }).Take(10);

            var query3 = (from team in Formula1.GetContructorChampions()
                         from year in team.Years
                         join champ in from champion in Formula1.GetChampions()
                                       from year in champion.Years
                                       select new { year, champion.LastName }
                                 on year equals champ.year
                         select new { Year = year, TeamName = team.Name, ChampName = champ.LastName }).Take(10);




            //foreach (var winner in query1)
            //{
            //    Console.WriteLine("{0} - {1} - {2}", winner.Year, winner.Name, winner.TeamName);
            //}

            //foreach (var winner in query2)
            //{
            //    Console.WriteLine("{0} - {1} - {2}", winner.Year, winner.ChampName, winner.TeamName);
            //}
            //Console.ReadKey();



            foreach (var winner in query3)
            {
                Console.WriteLine("{0} - {1} - {2}", winner.Year, winner.TeamName, winner.ChampName);
            }
            Console.ReadKey();

        }
    }

}
