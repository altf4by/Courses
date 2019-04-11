using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class BadPupil : Pupil
    {
        public BadPupil(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public override void Study()
        {
            Console.WriteLine("bad pupil {0} studying", FullName);
        }

        public override void Write()
        {
            Console.WriteLine("bad pupil {0} writing", FullName);
        }

        public override void Read()
        {
            Console.WriteLine("bad pupil {0} reading", FullName);
        }

        public override void Relax()
        {
            Console.WriteLine("bad pupil {0} relaxing", FullName);
        }
    }
}
