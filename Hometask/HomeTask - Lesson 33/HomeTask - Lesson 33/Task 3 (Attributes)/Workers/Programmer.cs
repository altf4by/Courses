using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3__Attributes_.Workers
{
    [AccessLevel(AccessLevelAttribute.AccessLevel.Full)]
    class Programmer:Worker
    {
        public Programmer(string name) : base(name) { }
    }
}
