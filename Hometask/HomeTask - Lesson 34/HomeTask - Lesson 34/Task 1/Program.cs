using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static object sync = new object();

        static void Main(string[] args)
        {
            string path1 = @"C:\file1.txt";
            string path2 = @"C:\file2.txt";

            Thread thread1 = new Thread(WriteDataToFile);
            Thread thread2 = new Thread(WriteDataToFile);


            thread1.Start(path1);
            thread2.Start(path2);



            Console.ReadKey();

        }

        static void WriteDataToFile(object path)
        {
            string path3 = @"C:\file3.txt";
            string s;

            using (StreamReader reader = new StreamReader(path.ToString()))
            {
                s = reader.ReadToEnd();
            }
            lock (sync)
            {
                using (StreamWriter sw = new StreamWriter(path3, true))
                {
                    sw.Write(s);
                }
            }

        }
    }
}
