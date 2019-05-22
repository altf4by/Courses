using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDealer dealer = new CarDealer();
            Consumer Michael = new Consumer("Michael");
            dealer.NewCarInfo += Michael.NewCarIsHere;
            dealer.NewCar("Ferrari");
            Consumer Sebastian = new Consumer("Sebastian");
            dealer.NewCarInfo += Sebastian.NewCarIsHere;
            dealer.NewCar("Mercedes");
            dealer.NewCarInfo -= Michael.NewCarIsHere;
            dealer.NewCar("Red Bull Racing");

            Console.ReadKey();
        }
    }

    public class CarInfoEventArgs : EventArgs
    {
        public string Car { get; private set; }

        public CarInfoEventArgs(string car)
        {
            this.Car = car;
        }

    }

    public class CarDealer
    {
        public event EventHandler<CarInfoEventArgs> NewCarInfo;

        public void NewCar(string car)
        {
            Console.WriteLine("CarDealer, new car {0}", car);
            RaiseNewCarInfo(car);
        }

        protected virtual void RaiseNewCarInfo(string car)
        {
            EventHandler<CarInfoEventArgs> newCarlnfo = NewCarInfo;
            if (newCarlnfo != null)
            {
                newCarlnfo(this, new CarInfoEventArgs(car));
            }
        }
    }

    public class Consumer
    {
        private string name;

        public Consumer(string name)
        {
            this.name = name;
        }

        public void NewCarIsHere(object sender, CarInfoEventArgs e)
        {
            Console.WriteLine("{0} : car {1} is new", name, e.Car);
        }
    }

}
