using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static object locker = new object();
        
        static void Main(string[] args)
        {
            string file1 = @"C:\File1.txt";
            string file2 = @"C:\File2.txt";


            Thread thread1 = new Thread(() => WriteToFile(file1));
            Thread thread2 = new Thread(() => WriteToFile(file2));

            thread1.Start();
            thread2.Start();
            thread2.Join();

            Console.ReadKey();
        }

        static void WriteToFile(object obj)
        {
            string file3 = @"C:\File3.txt";
            string info;
            bool lockTaken = false;

            try
            {
                Monitor.Enter(locker, ref lockTaken);

                using (StreamReader sr = new StreamReader(obj.ToString()))
                {
                    info = sr.ReadToEnd();

                    using (StreamWriter sw = new StreamWriter(file3, append: true))
                    {
                        sw.Write(info);
                        Console.WriteLine("Writing to the file is over.");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
               if(lockTaken) Monitor.Exit(locker);
            }
            
        }
    }
}
