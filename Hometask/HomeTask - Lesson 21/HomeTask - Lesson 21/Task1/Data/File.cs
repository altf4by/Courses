using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Data
{
    class File
    {
        public double Size { get; set; }

        public File() : this(780) { }
 
        public File(double size)
        {
            Size = size;
        }
    }
}
