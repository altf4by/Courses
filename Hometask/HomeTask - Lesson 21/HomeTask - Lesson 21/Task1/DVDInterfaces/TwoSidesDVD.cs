using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DVDInterfaces
{
    class TwoSidesDVD : IDVD_Interface
    {
        public int SidesQuantity { get { return 2; } }
        //public double Capacity { get { return 4.7; } }
    }
}
