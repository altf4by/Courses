using System;
using Task3.Interfaces;

namespace Task3.Behavoirs
{
    class EditBehavoir : IEditable
    {
        public void Edit()
        {
            Console.WriteLine("can EDIT");
        }
    }
}
