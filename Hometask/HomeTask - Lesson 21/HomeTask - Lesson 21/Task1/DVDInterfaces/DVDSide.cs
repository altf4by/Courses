using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DVDInterfaces
{
    class DVDSide
    {
        private const double _capacity = 4.7;
        public double EmptyCapacity { get; set; }

        public DVDSide()
        {
            EmptyCapacity = _capacity;
        }

        public double GetSideCapacity()
        {
            return _capacity;
        }

    }
}
