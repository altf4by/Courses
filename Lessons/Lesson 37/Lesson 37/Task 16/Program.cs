using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_16
{
    using System.IO;
    class Program
    {
        static void Main()
        {
            var stream = new FileStream("file.txt", FileMode.Open, FileAccess.Read);

            var array = new byte[stream.Length];


            IAsyncResult asyncResult = stream.BeginRead(array, 0, array.Length, null, null);

            Console.WriteLine("Чтение файла ...");

            stream.EndRead(asyncResult);

            foreach (byte item in array)
                Console.Write(item + " ");

            stream.Close();

            Console.ReadKey();
        }
    }


}
