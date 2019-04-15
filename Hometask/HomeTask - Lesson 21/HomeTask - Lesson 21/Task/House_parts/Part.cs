using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.House_parts
{
    public abstract class Part : IPart
    {
        public bool IsReady { get; private set; }

        public int PercentReady
        {
            get
            {
                return _percentReady;
            }
            set
            {
                if (value >= 100)
                {
                    _percentReady = 100;
                    IsReady = true;
                }
                else
                {
                    _percentReady = value;
                }
            }
        }

        private int _percentReady;

        public void DisplayInfo()
        {
            Console.WriteLine("{0} is finished at {1}%.", GetType().Name, PercentReady);
        }
    }
}
