using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Car
    {
        protected string name;
        protected short currentSpeed;
        protected short maxSpeed;
        protected EngineState state;


        protected Car()
        {
            state = EngineState.EngineAlive;
        }

        protected Car(string name, short maxSpeed, short currentSpeed)
            : this()
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.currentSpeed = currentSpeed;
        }


        public abstract void Acceleration();

        public void Driver(string name, int age)
        {
            Console.WriteLine("Имя водителя: {0}. Возраст: {1}", name, age);
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public short CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        public short MaxSpeed
        {
            get { return maxSpeed; }
        }

        public EngineState EngineState
        {
            get { return state; }
        }
    }
    public enum EngineState
    {
        EngineAlive,
        EngineDead
    }
    public class MiniVan : Car
    {
        public MiniVan()
        {
        }

        public MiniVan(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {
        }

        public override void Acceleration()
        {
            state = EngineState.EngineDead;
            Console.WriteLine("MINIVAN:  Двигатель сгорел!");
        }
    }



    public class SportsCar : Car
    {
        public SportsCar()
        {
        }

        public SportsCar(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {
        }

        public override void Acceleration()
        {
            Console.WriteLine("SPORTCAR:  Быстрая скорость!");

        }
    }

    internal class SecretCar : Car
    {
        public override void Acceleration()
        {
            throw new NotImplementedException();
        }
    }

}
