using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.USBIntefaces
{
    interface IUSB_Interface
    {
        double ReadSpeed { get; }
        double WriteSpeed { get; }
    }
}
