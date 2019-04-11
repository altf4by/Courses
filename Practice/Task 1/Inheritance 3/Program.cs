using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(80);

            myCar.Speed = 50;
            Console.WriteLine("My car is giong {0}", myCar.Speed);

            MiniVan myVan = new MiniVan();

            myVan.Speed = 10;
            Console.WriteLine("My MiniVan is giong {0}", myVan.Speed);



            Console.ReadKey();
        }
    }

    class Car
    {
        public readonly int maxSpeed;
        private int currSpeed;
        public Car(int max)
        {
            maxSpeed = max;
        }
        public Car()
        {
            maxSpeed = 55;
        }

        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }
    }

    class MiniVan : Car
    {

    }
}
