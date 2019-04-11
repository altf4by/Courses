using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Ducks
{
    class ExoticDuck : Duck
    {

        public ExoticDuck():base(new SimpleFly(), new ExoticQryak())
        {
        }
        public override void Display()
        {
            Console.WriteLine("I'm an Exotic Duck");
        }
    }
}
