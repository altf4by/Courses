using Task1.Enums;

namespace Task1.Storages
{
    abstract class Storage
    {
        protected string Model { get; set; }
        public StorageType StorageType { get; set; }
        public double EmptyCapacity { get; set; }


        public Storage(string model, StorageType type)
        {
            Model = model;
            StorageType = type;
        }


        public abstract double GetCapacity();

        public abstract void CopyDataToDevice(User user);

        public abstract double GetEmptyCapacity();

        public abstract string GetDeviceInfo();


    }
}
