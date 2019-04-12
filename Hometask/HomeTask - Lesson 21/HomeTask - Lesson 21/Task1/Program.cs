using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Storages;
using Task1.Data;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Flash flash = new Flash();
            //Console.WriteLine(flash.GetDeviceInfo());


            DVD dvd = new DVD();
            Console.WriteLine(dvd.GetDeviceInfo());
            //Console.WriteLine();
            //flash.CopyFileToDevice(new File(3.95));

            //Console.WriteLine(flash.GetDeviceInfo());


            //User user = new User(flash);
            //user.StartCopy();

            Console.ReadKey(true);
        }
    }
}
