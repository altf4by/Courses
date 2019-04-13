using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Enums;
using Task1.Data;

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
