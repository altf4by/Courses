using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Storages;
using Task1.Information;
using Task1.DVDInterfaces;
using Task1.Enums;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash = new Flash();
            Console.WriteLine(flash.GetDeviceInfo());
            Console.WriteLine();

            DVD dvdOneSide = new DVD("ACME 003237", new OneSideDVD());
            Console.WriteLine(dvdOneSide.GetDeviceInfo());
            Console.WriteLine();

            DVD dvdTwoSides = new DVD("ACME 003237", new TwoSidesDVD());
            Console.WriteLine(dvdTwoSides.GetDeviceInfo());
            Console.WriteLine();

            ExternalHDD extHDD = new ExternalHDD();
            Console.WriteLine(extHDD.GetDeviceInfo());
            Console.WriteLine();

            User user = new User(flash);
            Data data = new Data(565);

            Console.WriteLine("It took seconds to copy important data from PC:");
            Console.WriteLine("Flash: {0}", user.MoveData(new Data(565)));
            Console.WriteLine("DVD - one side: {0}", new User(dvdOneSide).MoveData(new Data(565)));
            Console.WriteLine("DVD - two sides: {0}", new User(dvdTwoSides).MoveData(new Data(565)));
            Console.WriteLine("External HDD: {0}", new User(extHDD).MoveData(new Data(565)));

            Console.ReadKey(true);
        }
    }
}
