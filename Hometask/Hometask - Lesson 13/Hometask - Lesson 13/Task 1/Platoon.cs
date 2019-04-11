using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Platoon
    {
        static Random rand = new Random();
        private string Name { get; set; }
        public int Length { get; }
        private Tank[] tanks;

        public Platoon(string tankName, int size, Random rand)
        {
            tanks = new Tank[size];
            FillTeam(tankName, rand);
        }

        public Tank this[int index]
        {
            get { return tanks[index]; }
            set { tanks[index] = value; }
        }

        private void FillTeam(string tankName, Random rand)
        {
            for (int i = 0; i < tanks.Length; i++)
                tanks[i] = new Tank(tankName, rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
        }


        public void Add(Tank tank)
        {
            Tank[] temp = new Tank[tanks.Length + 1];
            Array.Resize(ref tanks, tanks.Length + 1);
            tanks[Length-1]=tank;
        }
    }
}
