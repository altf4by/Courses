using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class SimpleQryak:IQryakable
    {
        public virtual void Qryak()
        {
            Console.WriteLine("I'm qryaking.");
        }
    }
}
