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
            Console.WriteLine("Было затрачено секунд на копирование информации:");
            Console.WriteLine(user.StartCopy(user.GetStorageByType(StorageType.DVD)));
            user.StartCopy(user.GetStorageByType(StorageType.DVD));


            Console.ReadKey(true);
        }
    }
}
