using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Auto
    {
        public string CarName { get; set; }

        public int MaxSpeed { get; set; }

        public double Cost { get; set; }

        public byte Discount { get; set; }

        public int ID { get; set; }

        public Auto() { }

        public Auto(string carName, int maxSpeed, double cost, byte discount, int id)
        {
            CarName = carName;
            MaxSpeed = maxSpeed;
            Cost = cost;
            Discount = discount;
            ID = id;
        }

        public override string ToString()
        {
            return String.Format("{0}\tМарка: {1}\tМакс. скорость: {2}\tЦена: {3:C}\tСкидка: {4}%",
                ID, CarName, MaxSpeed, Cost, Discount);
        }
    }
}
