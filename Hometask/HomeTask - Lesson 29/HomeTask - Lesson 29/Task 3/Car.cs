using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string brand, string model, int year, string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
        }

        public override string ToString()
        {
            return string.Format(Color + Brand + Model +"is produced in"+ Year);
        }
    }
}
