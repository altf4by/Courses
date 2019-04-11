using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    interface IWildCat
    {
        string Breed { get; } // порода дикой кошки
        void Growl();  // рычание
        void Scratch();
    }

}
