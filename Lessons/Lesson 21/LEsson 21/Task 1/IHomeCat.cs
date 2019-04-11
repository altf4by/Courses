using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    interface IHomeCat
    {
        string Name { get; set; }
        void Meow();
        void Scratch();// царапаться
    }

}
