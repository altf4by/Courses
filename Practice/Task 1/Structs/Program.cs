using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Point myPoint;

            myPoint.X = 349;
            myPoint.Y = 76;

            myPoint.Display();

            myPoint.Increment();
            myPoint.Display();

            Point p2 = new Point(50, 60);
            p2.Display();

            Point p3 = p2;
            p3.Display();

            p2.X = 100;

            Console.WriteLine(" \n=> Changed p1.X\n ");
            p2.Display();
            p3.Display();

            ReferenceTypeAssignmeпt();

            Console.ReadKey();

        }

        static void ReferenceTypeAssignmeпt()
        {

            Console.WriteLine("Assigning reference type s\n");

            PointRef p1 = new PointRef(10, 10);           
            PointRef p2 = p1;
            p1.Display();
            p2.Display();

            p1.X = 100;
            Console.WriteLine(" \n=> Changed p1.X\n ");

            p1.Display();
            p2.Display();


        }
    }


}
