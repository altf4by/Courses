using Task1.Storages;
namespace Task1.DVDInterfaces
 
{
    class OneSideDVD : IPartitionable
    {
        public OneSideDVD()
        {        
        }
        public int PartitionsQuantity { get { return 1; } }
    }
}
