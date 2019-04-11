using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    struct Train
    {
        private string destination;
        private string _number;
        public string Number { get { return _number; } set { _number = value; } }
        DateTime departureTime;

        public Train(string destination, string number, DateTime departureTime)
        {
            this.destination = destination;
            _number = number;
            this.departureTime = departureTime;
        }
        public string Display()
        {
            if (this.Number != "exit" && this.Number != "0")
                return string.Format("Train number \"{0}\" to {1} departures at {2:HH:mm}", Number, destination, departureTime);
            else return string.Format("There is no a train with such number");
        }
    }
}
