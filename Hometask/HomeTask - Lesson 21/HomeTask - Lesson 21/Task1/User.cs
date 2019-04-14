using Task1.Data;
using Task1.Storages;
using Task1.USBIntefaces;
using Task1.DVDInterfaces;
using Task1.Enums;
using System;


namespace Task1
{
    class User
    {
        public Storage[] storages;

        //public int quantityOfDeviceUse;

        public Information infoOnPC { get; set; }

        public int FileNumberToCopy { get; set; }


        public User()
        {
            storages = new Storage[4];
            storages[0] = new Flash("Kingston DataTraveler 2000", 4, new USB_3_0());
            storages[1] = new DVD();
            storages[2] = new DVD("ACME QT4710", new TwoSidesDVD());
            storages[3] = new ExternalHDD("Western Digital WDBUZG 5000ABK", 3, new USB_2_0());

            infoOnPC = new Information(490);
        }


        public Storage GetStorageByType(StorageType storageType)
        {
            foreach (Storage storage in storages)
                if (storageType == storage.StorageType)
                    return storage;

            return new Flash();
        }

        public int CopyToDevice(Storage storage)
        {
            return storage.CopyDataToDevice(this);
        }

        public int CopyFromDevice(Storage storage)
        {
            double copiedSize = 0;
            do
            {
                copiedSize += storage.filesOnDevice[storage.filesOnDevice.Length - 1].Size;
                storage.EmptyCapacity += storage.filesOnDevice[storage.filesOnDevice.Length - 1].Size;
                Array.Resize(ref storage.filesOnDevice, storage.filesOnDevice.Length - 1);

            } while (storage.filesOnDevice.Length >= 1);

            return (int)(copiedSize / storage.GetReadSpeed());
        }

        public int StartCopy(Storage storage, out int quantityOfDeviceUse)
        {
            int TimeSpent = 0;
            quantityOfDeviceUse = 0;
            FileNumberToCopy = 0;
            do
            {
                TimeSpent += CopyToDevice(storage);
                TimeSpent += CopyFromDevice(storage);
                quantityOfDeviceUse++;
            } while (FileNumberToCopy != infoOnPC.TotalFilesQuantity);

            return TimeSpent;
        }


    }
}
