using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static object obj = new object();
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
            string s;
            string newFile = @"C:\file3.txt";
            using (StreamReader sr = new StreamReader(path.ToString()))
            {
                s = sr.ReadToEnd();
                lock (obj)
                {
                    using (StreamWriter sw = new StreamWriter(newFile, true))
                    {
                        sw.Write(s, true);
                    }
                }
                
            }

        }
    }
}
