using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysm_1
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreeDCircle o = new ThreeDCircle();
            o.Draw();
            ((Circle)o).Draw();

            //Shapes[] myShapes = {new Hexagon() , new Circle() , new Hexagon("Mick"),
            //    new Circle("Beth"), new Hexagon("Linda") };

            //foreach (Shapes shape in myShapes)
            //{
            //    shape.Draw();
            //}

            Console.ReadKey();
        }
    }
}
