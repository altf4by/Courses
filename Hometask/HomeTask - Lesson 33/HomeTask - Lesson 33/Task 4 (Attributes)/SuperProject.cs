using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4__Attributes_
{
    class SuperProject
    {


        public void NewVersion()
        {
            Console.WriteLine("That is a new version");
        }

        [Obsolete("You are using an old version. In the next issue you will not be able to use it anymore.")]
        public void OldVersion()
        {
            Console.WriteLine("That is an old version");
        }

        [Obsolete("You are using an old version. In the next issue you will not be able to use it anymore.",true)]
        public void OldVersion2()
        {
            Console.WriteLine("That is an old version");
        }
    }
}
