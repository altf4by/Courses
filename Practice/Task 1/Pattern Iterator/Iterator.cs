using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Iterator
{
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract object Current();
        public abstract bool IsDone();
    }
}
