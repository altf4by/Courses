using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.House_parts
{
    class Roof : IPart
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
            Console.WriteLine("{0} is ready for {1} percents.", GetType().Name, PercentReady);
        }

    }
}
