using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Ducks
{
    class RubberDuck : Duck
    {
        public RubberDuck():base(new NoFly(), new SimpleQryak())
        {

        }
        public override void Display()
        {
            Console.WriteLine("I'm a rubber Duck.");
        }


    }
}
