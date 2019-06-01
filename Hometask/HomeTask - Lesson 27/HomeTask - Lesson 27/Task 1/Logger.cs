using System;
using System.Collections.Generic;
using System.IO;

namespace Task_1
{
    class Logger
    {
        List<string> data = new List<string>();

        public void CollectPressedKeys(object sender, KeyPressedEventArgs e)
        {
            data.Add(string.Format("{0:HH:MM:s} | Key '{1}' |", DateTime.UtcNow, e.Key));
        }

        public void SaveResultsToFile(object sender, CounterEventArgs e)
        {
            Console.WriteLine("\nExecuting of the program stopped.");

            data.Add(string.Format(new string('-', 50) + "\nTotally was pressed {0} keys", e.Counter));

            if (!Directory.Exists(@"C:\MySpyDirectory"))
                Directory.CreateDirectory(@"C:\MySpyDirectory");

            string path = @"C:\MySpyDirectory\SpyFile.txt";

            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();               
            }

                File.WriteAllLines(path, data);
        }
    }
}
