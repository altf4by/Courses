using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysm_1
{
    abstract class Shapes
    {
        public string PetName { get; set; }

        public Shapes(string name = "No name")
        {
            PetName = name;
        }
        public abstract void Draw();
    }
}
