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
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            Car chuck = new Car();
            chuck.PrintState();

            Car mary = new Car("Mary");
            mary.PrintState();

            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.WriteLine();
            Motorcycle mc = new Motorcycle();
            mc.PopAWheely();

            Motorcycle mc2 = new Motorcycle(5);
            mc2.SetDriverName("Tiny");
            mc2.PopAWheely();

            Console.WriteLine();
            Console.WriteLine("Rider's driverName is {0}", mc2.driverName);

            Console.ReadLine();

        }
    }
}
