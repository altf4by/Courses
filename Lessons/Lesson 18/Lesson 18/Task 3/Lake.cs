using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.Ducks;

namespace Task_3
{
    class Lake
    {
        private Duck[] _ducks;
        private int _index;
        public int Count { get { return _index; } }

        public Lake()
        {
            _ducks = new Duck[4];
        }

        public void Add(Duck duck)
        {
            _ducks[_index++] = duck;
        }

        public Duck this[int index]
        {
            get { return _ducks[index]; }
            set { _ducks[index] = value; }
        }

        public void Display()
        {
            for (int i = 0; i < Count; i++)
            {
                _ducks[i].Display();
                _ducks[i].Swim();
                _ducks[i].Qryak();
                _ducks[i].Fly();

                Console.WriteLine();
            }
        }
    }
}
