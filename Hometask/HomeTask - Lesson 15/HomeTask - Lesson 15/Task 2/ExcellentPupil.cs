using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ExcellentPupil : Pupil
    {
        public ExcellentPupil(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Study()
        {
            Console.WriteLine("excellent pupil {0} studying", FullName);
        }

        public override void Write()
        {
            Console.WriteLine("excellent pupil {0} writing", FullName);
        }

        public override void Read()
        {
            Console.WriteLine("excellent pupil {0} reading", FullName);
        }

        public override void Relax()
        {
            Console.WriteLine("excellent pupil {0} relaxing", FullName);
        }
    }
}
