using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        public bool carIsDead { get; set; }

        public Car() { }
        public Car(string name, int maxSp, int currentSp)
        {
            PetName = name;
            CurrentSpeed = currentSp;
            MaxSpeed = maxSp;
        }

        public delegate void CarEngineHandler(string msgForCaller);

        private CarEngineHandler listOfHandlers;

        public void RegisterWithHandler(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
        }
        public void UnRegisterWithHandler(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Sorry, this car is dead...");
            }
                            
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                    listOfHandlers("Careful buddy! Gonna blow ");

                if (CurrentSpeed >= MaxSpeed)
                    {
                        carIsDead = true;

                    }
                    else Console.WriteLine("Current Speed = {0}", CurrentSpeed);
            }
        }
    }
}
