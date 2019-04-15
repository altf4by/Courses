using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    interface IWorker
    {
        string FullName { get; set; }
        void Work(IPart housePart);
    }
}
