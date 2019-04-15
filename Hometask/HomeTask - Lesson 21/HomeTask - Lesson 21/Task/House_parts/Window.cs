using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.House_parts
{
    class Window : IPart
    {
        public bool IsReady
        {
            get
            {
                if (PercentReady < 100)
                    return false;
                else
                {
                    PercentReady = 100;
                    return true;
                }
            }
            private set { }
        }

        public int PercentReady { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine("{0} is finished at {1}%.", GetType().Name, PercentReady);
        }
    }
}
