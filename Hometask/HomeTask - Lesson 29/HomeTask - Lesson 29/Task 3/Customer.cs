using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Customer
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public int Number { get; }
        public string Model { get; set; }

        public Customer(string name, int number, string model)
        {
            Name = name;
            Number = number;
            Model = model;
        }
    }
}
