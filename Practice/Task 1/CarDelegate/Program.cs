using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 100, 10);
            c1.RegisterWithHandler(new Car.CarEngineHandler(OnCarEngineEvent));
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithHandler(handler2);

            Console.WriteLine("***Speeding up***");

            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            c1.UnRegisterWithHandler(handler2);

            Console.WriteLine("***Speeding up***");

            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadKey();
        }
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("Message from Car");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("******************************\n");
        }
        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}
