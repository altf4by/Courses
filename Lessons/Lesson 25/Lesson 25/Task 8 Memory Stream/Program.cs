using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Memory_Stream
{
    class Program
    {
        static void Main()
        {
            MemoryStream memory = new MemoryStream();

            for (int i = 0; i < 256; i++)
            {
                memory.WriteByte((byte)i);
            }

            memory.Position = 0;

            for (int i = 0; i < 256; i++)
            {
                Console.Write(" " + memory.ReadByte());
            }

            Console.WriteLine("\n" + new string('-', 80));

            byte[] array = memory.ToArray();

            foreach (byte b in array)
            {
                Console.Write(b);
            }

            Console.WriteLine("\n" + new string('-', 80));

            FileStream file = new FileStream(@"E:\Dump.dat", FileMode.Create, FileAccess.ReadWrite);
            memory.WriteTo(file);

            file.Position = 0;

            for (int i = 0; i < 256; i++)
            {
                Console.Write(" " + file.ReadByte());
            }

            memory.Close();
            file.Close();

            Console.ReadKey();
        }

    }
}
