using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DVDInterfaces
{
    class OneSideDVD : IDVD_Interface
    {
        public int SidesQuantity { get { return 1; } }
    }
}
