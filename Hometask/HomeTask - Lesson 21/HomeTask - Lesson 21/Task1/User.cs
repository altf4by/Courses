using Task1.Data;
using Task1.Storages;
using Task1.USBIntefaces;
using Task1.DVDInterfaces;
using Task1.Enums;


namespace Task1
{
    class User
    {
        public Storage[] storages;

        public int TimeSpent { get; set; }
        public int QuantityOfDeviceUse { get; set; }

        public Information infoOnPC { get; set; }

        public int FileNumberToCopy { get; set; }



        public User()
        {
            storages = new Storage[4];
            storages[0] = new Flash("Kingston DataTraveler 2000", 4, new USB_3_0());
            storages[1] = new DVD();
            storages[2] = new DVD("ACME QT4710", new TwoSidesDVD());
            storages[3] = new ExternalHDD("Western Digital WDBUZG 5000ABK", 3, new USB_2_0());

            infoOnPC = new Information(565);
        }


        //public User(Storage storage)
        //{
        //    TimeSpent = 0;
        //    QuantityOfDeviceUse = 0;
        //    StorageToCopy = storage;
        //    FileNumberToCopy = 0;
        //}
        public Storage GetStorageByType(StorageType storageType)
        {
            foreach (Storage storage in storages)
            {
                if (storageType == storage.StorageType)
                    return storage;
            }                
            return new Flash();
        }

        public void CopyToDevice(Storage storage)
        {
            storage.CopyDataToDevice(this);
        }

        public void CopyFromDevice()
        {

        }

        public int StartCopy(Storage storage)
        {
            TimeSpent = 0;
            do
            {
                CopyToDevice(storage);
                CopyFromDevice();
            } while (FileNumberToCopy != infoOnPC.TotalFilesQuantity);

            return TimeSpent;
        }


    }
}
