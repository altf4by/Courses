using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum StorageTypes:byte
{FLASH, DVD, HDD}

namespace Task_1.Storages
{
    abstract class Storage
    {
        public abstract StorageTypes StorageType { get; set; }
        protected string Model { get; set; }

        public double CapacityInBytes { get; set; }

        public double ReadSpeed { get; set; }
        public double WriteSpeed { get; set; }


        public abstract double GetCapacity();


    }
}
