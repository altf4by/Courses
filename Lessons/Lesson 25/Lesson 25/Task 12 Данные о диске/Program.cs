using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_Данные_о_диске
{
    class Program
    {
        static void Main()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Drive: {0} Type: {1}", drive.Name, drive.DriveType);
            }


            Console.ReadKey();
        }

    }
}
