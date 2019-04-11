using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            IHomeCat vaska = new YardCat();
            vaska.Name = "Васька";
            CatInfoPrinter.PrintCatInfo(vaska);

            IHomeCat wagner = new PedigreeCat();
            wagner.Name = "Вагнер";
            CatInfoPrinter.PrintCatInfo(wagner);

            CatInfoPrinter.PrintCatInfo(new HomeCatAdaptor (new Tiger()));

            Console.ReadKey();

        }
    }
}
