using Task1.Storages;
namespace Task1.DVDInterfaces
{
    class TwoSidesDVD : IPartitionable
    {
        public int PartitionsQuantity { get { return 2; } }
    }
}
