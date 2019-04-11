using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Tank
    {
        public string Name { get; private set; }
        public int Ammunition { get; private set; }
        public int Armor { get; private set; }
        public int Mobility { get; private set; }

        public Tank(string name, int ammunition, int armor, int mobility)
        {
            Name = name;
            Ammunition = ammunition;
            Armor = armor;
            Mobility = mobility;
        }

        public static bool operator >(Tank team1, Tank team2)
        {
            return Comparer(team1, team2) >= 2;
        }
        public static bool operator <(Tank team1, Tank team2)
        {
            return Comparer(team1,team2) < 2;
        }
        public static int Comparer(Tank team1, Tank team2)
        {
            int counter = 0;
            if (team1.Ammunition > team2.Ammunition)
                counter++;
            if (team1.Armor > team2.Armor)
                counter++;
            if (team1.Mobility > team2.Mobility)
                counter++;
            return counter;
        }
    }
}
