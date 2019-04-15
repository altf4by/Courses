using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.House_parts
{
    class House
    {
        public IPart[] parts = new IPart[11];

        public House()
        {
            parts = new IPart[11];

            parts[0] = new Basement();
            for (int i = 1; i < 5; i++)
                parts[i] = new Wall();
            parts[5] = new Door();
            for (int i = 6; i < 10; i++)
                parts[i] = new Window();
            parts[10] = new Roof();
        }
    }
}
