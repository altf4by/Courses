using Task1.Information;
namespace Task1
{
    class Partition
    {
        public double Capacity { get; set; }
        public double EmptyCapacity { get; set; }
        public File[] filesOnPartition;

        public Partition(double size)
        {
            Capacity = size * 1024;
            EmptyCapacity = Capacity;
            filesOnPartition = new File[0];
        }

    }
}
