using System;
using Task3.Behavoirs;

namespace Task3
{
    class Guest : User
    {
        public Guest() : base(new NoEditBehavior(), new NoAddBehavior(), new NoDeleteBehavior())
        {
        }

        public override void Read()
        {
            Console.WriteLine("can READ");
        }

    }
}
