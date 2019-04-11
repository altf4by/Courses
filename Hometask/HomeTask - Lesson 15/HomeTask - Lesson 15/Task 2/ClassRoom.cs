using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ClassRoom
    {
        private Pupil[] pupils;
        protected static int Count { get; set; }
        private const int CLASS_SIZE = 4;
        public int Length { get { return pupils.Length; } }

        public ClassRoom(Pupil pupil)
        {
            pupils = new Pupil[CLASS_SIZE];
            if (Count <= CLASS_SIZE && pupil != null)
                pupils[Count++] = pupil;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2) : this(pupil1)
        {
            if (Count <= CLASS_SIZE && pupil2 != null)
                pupils[Count++] = pupil2;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3) : this(pupil1,pupil2)
        {
            if (Count <= CLASS_SIZE && pupil3 != null)
                pupils[Count++] = pupil3;
        }

        public Pupil this[int index]
        {
            get
            {
                if (index >= 0 && index <= Length)
                    return pupils[index];
                else return null;
            }
            set
            {
                if (index >= 0 && index <= Length && value != null)
                    pupils[index] = value;
                else
                    Console.WriteLine("Input was incorrect");
            }
        }

        public void AddPupil(Pupil pupil)
        {
            if (pupil != null && Count <Length)
                pupils[Count++] = pupil;
            else
            {
                Console.WriteLine("It's impossible to add {0}",pupil.FullName);
            }
        }
    }
}
