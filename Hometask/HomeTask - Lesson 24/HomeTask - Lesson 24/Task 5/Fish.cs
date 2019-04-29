using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Fish
    {
        public string name;

        public Fish(string name)
        {
            this.name = name;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Fish other = obj as Fish;
            if (other==null)
                return false;

            return other.name == name;
        }
    }
}
