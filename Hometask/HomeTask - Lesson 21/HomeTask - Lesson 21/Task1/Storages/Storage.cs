using Task1.Enums;
using Task1.Data;

namespace Task1.Storages
{
    abstract class Storage
    {
        protected string Model { get; set; }
        public StorageType StorageType { get; set; }
        public double EmptyCapacity { get; set; }

        public File[] filesOnDevice;

        public Storage(string model, StorageType type)
        {
            Model = model;
            StorageType = type;
            filesOnDevice = new File[0];
        }


        public abstract double GetCapacity();

        public abstract int CopyDataToDevice(User user);

        public abstract double GetEmptyCapacity();

        public abstract string GetDeviceInfo();


    }
}
