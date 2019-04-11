using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class AbstractHandler
    {
        public void Open()
        {
            Console.WriteLine("Document is opened");
        }

        public void Create()
        {
            Console.WriteLine("Document is created");
        }
        public void Change()
        {
            Console.WriteLine("Document is changed");
        }
        public abstract void Save();
    }
}
