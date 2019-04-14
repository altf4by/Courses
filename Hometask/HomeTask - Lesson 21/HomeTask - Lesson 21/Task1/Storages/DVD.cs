using Task1.DVDInterfaces;
using Task1.Enums;
using System;
using Task1.Information;

namespace Task1.Storages
{
    class DVD : Storage
    {
        public const double ReadSpeed = 10.56 * 1024;
        public const double WriteSpeed = 10.56 * 1024;

        public IPartitionable dvdType;

        public DVD() : this("ACME 003237", new OneSideDVD()) { }

        public DVD(string model, IPartitionable dvdType) : base(model, StorageType.DVD)
        {
            this.dvdType = dvdType;

            partitions = new Partition[dvdType.PartitionsQuantity];

            for (int i = 0; i <= partitions.Length - 1; i++)
                partitions[i] = new Partition(4.7);

        }


        public override double GetReadSpeed()
        {
            return ReadSpeed / 1024;
        }

        public override double GetWriteSpeed()
        {
            return WriteSpeed / 1024;
        }

        public override int CopyDataToDevice(Data data)
        {
            double copiedSize = 0;

            for (int i = 0; i <= partitions.Length - 1; i++)
            {
                Partition partition = partitions[i];
                File copiedFile = data[data.NumberOfCopiedFiles];

                while (partition.EmptyCapacity >= copiedFile.Size
                    && data.NumberOfCopiedFiles != data.TotalFilesQuantity)
                {
                    copiedSize += copiedFile.Size;
                    partition.EmptyCapacity -= copiedFile.Size;

                    Array.Resize(ref partition.filesOnPartition, partition.filesOnPartition.Length + 1);
                    partition.filesOnPartition[partition.filesOnPartition.Length-1] = data[data.NumberOfCopiedFiles++];
                }
            }
            return (int)(copiedSize / (WriteSpeed / 1024));
        }

        public override double GetCapacity()
        {
            double capacity = 0;
            for (int i = 0; i < partitions.Length; i++)
                capacity += partitions[i].Capacity;

            return capacity * 1024;
        }

        public override double GetEmptyCapacity()
        {
            double emptyCapacity = 0;
            for (int i = 0; i < partitions.Length; i++)
                emptyCapacity += partitions[i].Capacity;
            return emptyCapacity;
        }

        public override string GetDeviceInfo()
        {
            return string.Format("Тип носителя и модель: {0}-{1}\nОбъем носителя: {2} Gb" +
             "\nСвободный объем: {3} Gb\nКоличество сторон: {4}\nСкорость (чтение/запись): {5} / {6} Kb/s",
                StorageType, Model, GetCapacity(), GetEmptyCapacity() / 1024, partitions.Length, ReadSpeed, WriteSpeed);
        }
    }
}
