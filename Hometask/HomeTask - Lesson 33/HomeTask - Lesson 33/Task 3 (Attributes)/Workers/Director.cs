using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3__Attributes_.Workers
{
    [AccessLevel(AccessLevelAttribute.AccessLevel.Partial)]
    class Director:Worker
    {
        public Director(string name) : base(name) { }
    }
}
