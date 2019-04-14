using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MoveDataResult
    {
        public int TimeSpent { get; }

        public int QuantityOfDeviceUse { get; }

        public bool Succeed { get; set; }


        public MoveDataResult(int timeSpent, int numbOfDeviceUse, bool succeed)
        {
            TimeSpent = timeSpent;
            QuantityOfDeviceUse = numbOfDeviceUse;
            Succeed = succeed;
        }
        public override string ToString()
        {
            return string.Format("{0} seconds and {1} time(s)",TimeSpent, QuantityOfDeviceUse);
        }
    }
}
