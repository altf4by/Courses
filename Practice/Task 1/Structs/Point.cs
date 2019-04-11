using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Increment()
        {
            X++;
            Y++;
        }
        public void Decrement()
        {
            X--;
            Y--;
        }
        public void Display()
        {
            Console.WriteLine("X = {0}, У = {1} ", X, Y);
        }

    }
}
