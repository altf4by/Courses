using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class HandlerProvider
    {
        public bool IsSigned { get; set; } = false;

        public void SomeMethod(object sender, SomeEventArgs e)
        {
            Console.WriteLine("{0} - was signed at event",e.MyProperty);

            if (!IsSigned==true)
            {
                IsSigned = true;
            }
        }
    }
}
