using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class Car
    {
        public const int MaxSpeed = 100;

        public int CurentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool carIsDead;

        private Radio theMusicBox = new Radio();

        public Car()
        {
        }

        public Car(string name, int speed)
        {
            CurentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {

            if (carIsDead)
                Console.WriteLine("{0} is out of order", PetName);
            else
            {
                CurentSpeed += delta;
                if (CurentSpeed >= MaxSpeed)
                {
                    CurentSpeed = 0;
                    carIsDead = true;

                    CarIsDeadException ex = 
                        new CarIsDeadException (string.Format("{0} has overheated", PetName), "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.CarsRUs.com";
                    throw ex;
                }
                else Console.WriteLine("Current speed = {0}", CurentSpeed);
            }
        }
    }
}
