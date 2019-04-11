using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Ducks
{
    class WoodDuck:Duck
    {
        public WoodDuck():base(new NoFly(), new NoQryak())
        {


        }

        public override void Display()
        {
            Console.WriteLine("I'm a wood Duck.");
        }

    }
}
