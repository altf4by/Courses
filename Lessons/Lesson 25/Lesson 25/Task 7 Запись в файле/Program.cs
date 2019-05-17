using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Запись_в_файле
{
    class Program
    {
        static void Main()
        {

            FileStream stream = new FileStream(@"C:\Test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 0; i < 256; i++)
                stream.WriteByte((byte)i);

            Console.WriteLine(stream.Position);

            stream.Position = 0;

            for (int i = 0; i < 256; i++)
            {
                Console.Write(" " + stream.ReadByte());
            }

            stream.Close();

            Console.ReadKey();
        }

    }
}
