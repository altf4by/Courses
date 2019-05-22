using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Logger
    {
        List<string> data = new List<string>();

        public void CollectPressedKeys(object sender, char ch)
        {
            data.Add(string.Format("{0:HH:MM:s} | Key '{1}'", DateTime.UtcNow, ch));
        }

        public void SaveResultsToFile(object sender, int counter)
        {
            Console.WriteLine("\nExecuting of the program stopped.");

            data.Add(string.Format(new string('-', 50) + "\nTotally was pressed {0} keys", counter-1));

            if (!Directory.Exists(@"C:\MySpyDirectory"))
                Directory.CreateDirectory(@"C:\MySpyDirectory");

            string path = @"C:\MySpyDirectory\SpyFile.txt";

            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();               
            }

            foreach (string str in data)
                File.WriteAllLines(path, data);
        }

    }
}
