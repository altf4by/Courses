using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Workers
{
    class Worker : IWorker
    {
        public string FullName { get; set; }

        public Worker(string name)
        {
            FullName = name;
        }


        public void Work(IPart housePart)
        {
            if (!housePart.IsReady && housePart.PercentReady < 100)
            {
                Console.WriteLine("{0} has started work with {1}", FullName, housePart.GetType().Name);
                housePart.PercentReady += 20;
                housePart.DisplayInfo();
            }
        }
    }
}
