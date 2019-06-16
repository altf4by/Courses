using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3__Attributes_.Workers;

namespace Task_3__Attributes_
{
    [AccessLevel(AccessLevelAttribute.AccessLevel.Denied)]
    class Manager : Worker
    {
        public Manager(string name) : base(name) { }

    }
}
