using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Month
    {
        public string Name { get; }

        public int Days { get; }

        public int Position { get; }

        public Month(string name, int position, int days)
        {
            Name = name;
            Days = days;
            Position = position;
        }

        public override string ToString()
        {
            return string.Format("{0} has {1} days.", Name, Days);
        }
    }
}
