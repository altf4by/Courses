using System;
using Task3.Behavoirs;

namespace Task3
{
    class Editor : User
    {
        public Editor() : base(new EditBehavoir(), new NoAddBehavior(), new NoDeleteBehavior())
        {
        }

        public override void Read()
        {
            Console.WriteLine("can READ");
        }
    }
}
