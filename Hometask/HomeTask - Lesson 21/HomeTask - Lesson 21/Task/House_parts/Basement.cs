using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.House_parts
{
    class Basement : IPart
    {
        //protected int _percentReady;
        public bool IsReady
        {
            get
            {
                if (PercentReady >= 100)
                {
                    PercentReady = 100;
                    return true;
                }
                else
                    return false;

            }
            private set { }
        }

        public int PercentReady
        {get;set;
            //get { return _percentReady; }
            //set
            //{
            //    if (value > 100)
            //        _percentReady = 100;
            //    else _percentReady = value;
            //}
        }


        public Basement() { }


        public void DisplayInfo()
        {
            Console.WriteLine("{0} is finished at {1}%.", GetType().Name, PercentReady);
        }
    }
}
