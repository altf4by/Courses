using Task1.Storages;
using Task1.USBIntefaces;
using Task1.DVDInterfaces;
using Task1.Enums;
using System;
using Task1.Information;


namespace Task1
{
    class User
    {
        public Storage Storage { get; private set; }

        public int NumberOfFile { get; set; }

        public User(Storage storage)
        {
            Storage = storage;
        }

        protected int CopyToDevice(Data data)
        {
            return Storage.CopyDataToDevice(data);
        }

        protected int CopyFromDevice(Storage storage)
        {
            double copiedSize = 0;

            for (int i = 0; i <= storage.partitions.Length - 1; i++)
            {
                Partition partition = storage.partitions[i];

                while (partition.filesOnPartition.Length >= 1)
                {
                    copiedSize += partition.filesOnPartition[partition.filesOnPartition.Length - 1].Size;

                    partition.EmptyCapacity += partition.filesOnPartition[partition.filesOnPartition.Length - 1].Size;

                    Array.Resize(ref partition.filesOnPartition, partition.filesOnPartition.Length - 1);
                }
            }

            return (int)(copiedSize / storage.GetReadSpeed());
        }

        public MoveDataResult MoveData(Data data)
        {
            if (data[0].Size > Storage.GetCapacity())
                return new MoveDataResult(0, 0, false);

            int timeSpent = 0,
                quantityOfDeviceUse = 0,
                FileNumberToCopy = 0;

            while (data.NumberOfCopiedFiles != data.TotalFilesQuantity)
            {
                timeSpent += CopyToDevice(data);
                timeSpent += CopyFromDevice(Storage);
                quantityOfDeviceUse++;
            }

            return new MoveDataResult(timeSpent, quantityOfDeviceUse, true);
        }
    }
}
