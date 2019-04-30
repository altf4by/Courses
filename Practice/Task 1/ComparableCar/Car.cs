using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Car: IComparable
    {
        private int _currSpeed;
        public int CarID { get; set; }
        public string Name { get; set; }
        public Car(string name, int speed, int id)
        {
            Name = name;
            _currSpeed = speed;
            CarID = id;
        }
        public static IComparer SortByName { get { return (IComparer)new PetNameComparer(); } }


        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp != null)
                return CarID.CompareTo(temp.CarID);
            else throw new ArgumentException("Parameter is not a car!");
        }
    }
}
