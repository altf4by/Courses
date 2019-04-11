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
            Car[] array = new Car[5];
            array[0] = new Car();
            array[1] = new Car("Fiat Stilo", 1.9, 5.5f);
            array[2] = new Car("Ford Mondeo");
            array[3] = new Car("Lada Granta", 1.6);
            array[4] = new Car("Jeep Cherokee", 4, 12f);




            Console.Write("Please, enter the distance of your trip: ");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
                array[i].SendToTrip(distance);

            Console.WriteLine($"Cost of the trip={distance}km and price of fuel = {Car.GetFuelPrice()}$");

            for (int i = 0; i < Car.GetCounter(); i++)
                Console.WriteLine($"{i + 1}.{array[i].GetBrand()} is {array[i].GetCostOfTrip()}");


            double volume = array[2].GetEngineVolume();
            Console.WriteLine($"\n{array[2].GetBrand()} engine volume = {volume} before grinding.");
            array[2].EngineGrinding(ref volume);
            Console.WriteLine($"{array[2].GetBrand()} engine volume = {volume} after grinding.");

            Console.ReadKey();

        }
    }


    class Car
    {
        string _brand;
        double _engineVolume;
        float _consumption;
        double _costOfTrip;
        double _amortization;


        static double _fuelPrice;
        static int _counter;

        static Car()
        {
            Console.Write("Let's show begin\nPlease, enter the price of fuel: ");
            _fuelPrice = double.Parse(Console.ReadLine());
        }
        public Car() : this("No name")
        {
        }
        public Car(string brand) : this(brand, 2.0)
        {
        }
        public Car(string brand, double engineVolume) : this(brand, engineVolume, 10.0f)
        {
        }
        public Car(string brand, double engineVolume, float consumption)
        {
            _brand = brand;
            _engineVolume = engineVolume;
            _consumption = consumption;
            _counter++;
        }


        public string GetBrand()
        {
            return _brand;
        }
        public double GetCostOfTrip()
        {
            return _costOfTrip;
        }
        public double GetEngineVolume()
        {
            return _engineVolume;
        }
        public void SendToTrip(int distance)
        {
            _costOfTrip = (distance * _fuelPrice) / _consumption;
        }
        public void EngineGrinding(ref double engineVolume)
        {
            engineVolume *= 1.01;
        }

        public static double GetFuelPrice()
        {
            return _fuelPrice;
        }
        public static int GetCounter()
        {
            return _counter;
        }
    }
}
