using Task1.Data;
using Task1.Storages;


namespace Task1
{
    class User
    {
        public int TimeSpent { get; set; }
        public int QuantityOfDeviceUse { get; set; }

        public Information infoOnPC { get; set; }
        public Storage StorageToCopy { get; set; }

        public int NumberOfFileToCopy { get; set; }


        public User(Storage storage)
        {
            TimeSpent = 0;
            QuantityOfDeviceUse = 0;
            infoOnPC = new Information(565);
            StorageToCopy = storage;
            NumberOfFileToCopy = 0;
        }

        public void CopyToDevice()
        {
            StorageToCopy.CopyDataToDevice(this);
        }
        
        public void CopyFromDevice()
        {

        }

        public void StartCopy()
        {
            do
            {
                CopyToDevice();
                CopyFromDevice();
            } while (NumberOfFileToCopy!=infoOnPC.TotalFilesQuantity);
        }

    }
}
