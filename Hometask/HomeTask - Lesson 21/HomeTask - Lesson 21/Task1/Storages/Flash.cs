using Task1.Enums;
using Task1.Information;
using Task1.USBIntefaces;
using System;

namespace Task1.Storages
{
    class Flash : Storage
    {
        public double Capacity { get; set; }
        public IUSB_Interface usbType;

        public Flash() : this("AData", 4, new USB_3_0()) { }

        public Flash(double capacity) : this("AData", capacity, new USB_3_0()) { }

        public Flash(string model, double capacity, IUSB_Interface usbType) : base(model, StorageType.Flash)
        {
            partitions = new Partition[1];
            partitions[0] = new Partition(capacity);
            Capacity = partitions[0].Capacity;
            this.usbType = usbType;
        }


        public override double GetReadSpeed()
        {
            return usbType.ReadSpeed/1024;
        }

        public override double GetWriteSpeed()
        {
            return usbType.WriteSpeed/1024;
        }

        public override int CopyDataToDevice(Data data)
        {
            double copiedSize = 0;
            Partition partition = partitions[0];
            File copiedFile = data[data.NumberOfCopiedFiles];

            while (partition.EmptyCapacity > copiedFile.Size && data.NumberOfCopiedFiles != data.TotalFilesQuantity)
            {
                copiedSize += copiedFile.Size;
                partition.EmptyCapacity -= copiedFile.Size;   
                
                Array.Resize(ref partition.filesOnPartition, partition.filesOnPartition.Length + 1);
                partition.filesOnPartition[partition.filesOnPartition.Length - 1] = data[data.NumberOfCopiedFiles++];
            }

            return (int)(copiedSize / GetWriteSpeed());
        }

        public void CopyFileToDevice(File file)
        {
            double copiedSize = 0;

            while (partitions[0].EmptyCapacity >= file.Size)
            {
                partitions[0].EmptyCapacity -= file.Size;
                copiedSize += file.Size;
                Array.Resize(ref partitions[0].filesOnPartition, partitions[0].filesOnPartition.Length + 1);
                partitions[0].filesOnPartition[partitions[0].filesOnPartition.Length - 1] = file;
            }
        }

        public override double GetCapacity()
        {
            return Capacity;
        }

        public override double GetEmptyCapacity()
        {
            return partitions[0].EmptyCapacity;
        }

        public override string GetDeviceInfo()
        {
            return string.Format("Тип носителя и модель: {0}-{1}\nОбъем носителя: {2} Gb" +
                                 "\nСвободный объем: {3} Gb\nСкорость (чтение/запись): {4} / {5} Kb/s",
                StorageType, Model, Capacity/1024, GetEmptyCapacity()/1024, usbType.ReadSpeed, usbType.WriteSpeed);
        }
    }
}
