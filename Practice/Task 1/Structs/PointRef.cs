using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class PointRef
    {
        public int X;
        public int Y;

        public PointRef(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, У = {1} ", X, Y);
        }
    }
}
