using Task3.Interfaces;

namespace Task3.Behavoirs
{
    class AddBehavior:IAddable
    {
        public void Add()
        {
            System.Console.WriteLine("can ADD");
        }
    }
}
