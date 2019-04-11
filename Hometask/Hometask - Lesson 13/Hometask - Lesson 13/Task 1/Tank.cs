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
        private const int WIN_COUNT = 2;

        public Tank(string name, int ammunition, int armor, int mobility)
        {
            Name = name;
            Ammunition = ammunition;
            Armor = armor;
            Mobility = mobility;
        }

        public static bool operator >(Tank tank1, Tank tank2)
        {
            return Comparer(tank1, tank2) >= WIN_COUNT;
        }
        public static bool operator <(Tank tank1, Tank tank2)
        {
            return Comparer(tank1, tank2) < WIN_COUNT;
        }
        private static int Comparer(Tank tank1, Tank tank2)
        {
            int counter = 0;
            if (tank1.Ammunition > tank2.Ammunition)
                counter++;
            if (tank1.Armor > tank2.Armor)
                counter++;
            if (tank1.Mobility > tank2.Mobility)
                counter++;
            return counter;
        }
    }
}
