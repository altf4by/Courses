using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Study()
        {
            Console.WriteLine("good pupil {0} studying", FullName);
        }

        public override void Write()
        {
            Console.WriteLine("good pupil {0} writing", FullName);
        }

        public override void Read()
        {
            Console.WriteLine("good pupil {0} reading", FullName);
        }

        public override void Relax()
        {
            Console.WriteLine("good pupil {0} relaxing", FullName);
        }
    }
}
