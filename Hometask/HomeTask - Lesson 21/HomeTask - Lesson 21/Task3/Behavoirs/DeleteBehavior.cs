using Task3.Interfaces;

namespace Task3.Behavoirs
{
    class DeleteBehavior : IDeletable
    {
        public void Delete()
        {
            System.Console.WriteLine("can Delete");
        }

    }
}