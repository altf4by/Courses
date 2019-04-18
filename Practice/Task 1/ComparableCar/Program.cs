using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] myAutos = new Car[5];

            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 80, 5);


            Array.Sort(myAutos);
            foreach (var car in myAutos)
                Console.WriteLine("{0} - {1}", car.Name, car.CarID);

            Console.WriteLine();
            Array.Sort(myAutos, Car.SortByName);

            foreach (var car in myAutos)
                Console.WriteLine("{0} - {1}", car.Name, car.CarID);


            Console.ReadLine();
        }

        
    }
}
