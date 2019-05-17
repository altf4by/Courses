using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_кроссплатформенность
{
    class Program
    {
        static void Main()
        {

            string path = @"C:\Windows\notepad.exe";
            Console.WriteLine(path);

            Console.WriteLine("Ext: {0}", Path.GetExtension(path));


            Console.WriteLine("Change Path: {0}", path = Path.ChangeExtension(path, "bak"));
            Console.WriteLine(path);

            Console.ReadKey();
        }

    }
}
