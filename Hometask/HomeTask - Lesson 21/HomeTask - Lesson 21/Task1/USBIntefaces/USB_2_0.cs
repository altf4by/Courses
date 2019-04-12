using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.USBIntefaces
{
    class USB_2_0 : IUSB_Interface
    {
        public double ReadSpeed { get { return 30 * 1024; } }
        public double WriteSpeed { get { return 20 * 1024; } }
    }
}
