using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Pupil
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }

        public Pupil(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void Study()
        {
            Console.WriteLine("studuing");
        }

        public virtual void Read()
        {
            Console.WriteLine("reading");
        }

        public virtual void Write()
        {
            Console.WriteLine("writing");
        }

        public virtual void Relax()
        {
            Console.WriteLine("relaxing");
        }

    }
}
