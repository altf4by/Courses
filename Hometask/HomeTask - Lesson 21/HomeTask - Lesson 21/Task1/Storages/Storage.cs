using Task1.Enums;
using Task1.Information;

namespace Task1.Storages
{
    abstract class Storage
    {
        protected string Model { get; set; }

        public StorageType StorageType { get; set; }

        public Partition[] partitions;
        

        public Storage(string model, StorageType type)
        {
            Model = model;
            StorageType = type;
        }


        public abstract double GetCapacity();

        public abstract int CopyDataToDevice(Data data);

        public abstract double GetEmptyCapacity();

        public abstract string GetDeviceInfo();

        public abstract double GetReadSpeed();
        public abstract double GetWriteSpeed();
    }
}
