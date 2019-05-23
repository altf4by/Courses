using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Task_11_События
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDealer dealer = new CarDealer();
            Consumer michael = new Consumer("Michael");
            WeakCarInfoEventManager.AddListener(dealer, michael);
            dealer.NewCar("Ferrari");
            Consumer Sebastian = new Consumer("Sebastian");
            WeakCarInfoEventManager.AddListener(dealer, Sebastian);
            dealer.NewCar("Mercedes");
            WeakCarInfoEventManager.RemoveListener(dealer, michael);
            dealer.NewCar("Red Bull Racing");

            Console.ReadKey();
        }
    }

    public class CarInfoEventArgs : EventArgs
    {
        public CarInfoEventArgs(string car)
        {
            this.Car = car;
        }
        public string Car { get; private set; }
    }

    public class WeakCarInfoEventManager : WeakEventManager
    {
        protected WeakCarInfoEventManager() { }

        public static void AddListener(object source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedAddListener(source, listener);
        }

        public static void RemoveListener(object source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedRemoveListener(source, listener);
        }

        public static WeakCarInfoEventManager CurrentManager
        {
            get
            {
                var manager = GetCurrentManager(typeof(WeakCarInfoEventManager)) as WeakCarInfoEventManager;
                if (manager == null)
                {
                    manager = new WeakCarInfoEventManager();
                    SetCurrentManager(typeof(WeakCarInfoEventManager), manager);
                }
                return manager;
            }
        }

        //вызывается при первом добавлении прослушивателя
        protected override void StartListening(object source)
        {
            (source as CarDealer).NewCarInfo += CarDealer_NewCarInfо;
        }

        void CarDealer_NewCarInfо(object sender, CarInfoEventArgs e)
        {
            //Доставляет управляемое событие к каждому прослушивателю.
            DeliverEvent(sender, e); // этот метод вызывает метод ReceiveWeakEvent в прослушивателях
        }

        //вызывается, когда удаляется последний прослушиватель
        protected override void StopListening(object source)
        {
            (source as CarDealer).NewCarInfo -= CarDealer_NewCarInfо;
        }
    }

    public class CarDealer
    {
        public event EventHandler<CarInfoEventArgs> NewCarInfo;

        public void NewCar(string car)
        {
            Console.WriteLine("CarDealer, new car {0}", car);
            RaiseNewCarlnfo(car);
        }

        protected virtual void RaiseNewCarlnfo(string car)
        {
            EventHandler<CarInfoEventArgs> newCarInfo = NewCarInfo;
            if (newCarInfo != null)
            {
                newCarInfo(this, new CarInfoEventArgs(car));
            }
        }
    }

    public class Consumer : IWeakEventListener
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

        bool IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e)
        {
            NewCarIsHere(sender, e as CarInfoEventArgs);
            return true;
        }
    }

}
