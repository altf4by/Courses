using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ThrdState
    {
        public int Number { get;}
        public AutoResetEvent ResetEvent { get; }
        public ThrdState(int number, AutoResetEvent reset)
        {
            Number = number;
            ResetEvent = reset;
        }
    }
}
