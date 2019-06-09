using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            SportsCar sportcar = new SportsCar("Viper", 240, 40);
            sportcar.Acceleration();

            MiniVan minivan = new MiniVan();
            minivan.Acceleration();

            Console.ReadKey();
        }

    }
}
