using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Storages;
using Task1.Data;
using Task1.DVDInterfaces;
using Task1.Enums;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Flash flash = new Flash();
            //Console.WriteLine(flash.GetDeviceInfo());

            //Console.WriteLine();

            //DVD dvd = new DVD("ACME 003237", new TwoSidesDVD());
            //Console.WriteLine(dvd.GetDeviceInfo());

            //Console.WriteLine();

            //ExternalHDD extHDD = new ExternalHDD();
            //Console.WriteLine(extHDD.GetDeviceInfo());

            //Console.WriteLine();

            User user = new User();
            int quantityOfDeviceUse = 0;
            Console.WriteLine("It took seconds to copy important data from PC:");
            Console.WriteLine("Flash: {0} seconds and {1} time(s)", user.StartCopy(user.GetStorageByType(user.storages[0].StorageType), out quantityOfDeviceUse), quantityOfDeviceUse);
            //Console.WriteLine("DVD - one side: {0} seconds and {1} time(s)", user.StartCopy(user.GetStorageByType(user.storages[1].StorageType), out quantityOfDeviceUse), quantityOfDeviceUse);
            //Console.WriteLine("DVD - side: {0} seconds and {1} time(s)", user.StartCopy(user.GetStorageByType(user.storages[2].StorageType), out quantityOfDeviceUse), quantityOfDeviceUse);
            Console.WriteLine("External HDD: {0} seconds and {1} time(s)", user.StartCopy(user.GetStorageByType(user.storages[3].StorageType), out quantityOfDeviceUse), quantityOfDeviceUse);

            //Console.WriteLine(user.StartCopy(user.GetStorageByType(StorageType.Flash)));

            Console.ReadKey(true);
        }
    }
}
