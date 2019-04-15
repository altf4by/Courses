using System;
using Task3.Behavoirs;

namespace Task3
{
    class Administrator : User
    {
        public Administrator() : base(new EditBehavoir(), new AddBehavior(), new DeleteBehavior())
        {
        }

        public override void Read()
        {
            Console.WriteLine("can READ");
        }
    }
}
