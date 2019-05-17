using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_BInary_Writer
{
    class Program
    {
        static void Main()
        {

            FileStream file = File.Create(@"C:\test.txt");

            BinaryWriter writer = new BinaryWriter(file);

            long number = 100;
            var bytes = new byte[] { 10, 20, 50, 100 };
            string s = "hunger";

            writer.Write(number);
            writer.Write(bytes);
            writer.Write(s);

            writer.Close();


            Console.ReadKey();
        }

    }
}
