using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Customer
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public decimal Sales { get; set; }
        public override string ToString()
        {
            return "ID: " + ID + " Город: " + City + " Страна: " + Country +
                " Регион: " + Region + " Продажи: " + Sales;
        }
    }

}
