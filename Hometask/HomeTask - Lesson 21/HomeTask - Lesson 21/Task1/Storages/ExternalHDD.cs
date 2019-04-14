using Task1.Enums;
using Task1.USBIntefaces;
using System;
using Task1.Information;

namespace Task1.Storages
{
    class ExternalHDD : Storage
    {
        protected IUSB_Interface usbType;


        public ExternalHDD() : this("Seagate ST905004EXA101-RK", 500, 3, new USB_2_0()) { }

        public ExternalHDD(string model, double size, int partitionsQuantity, IUSB_Interface usbType) : base(model, StorageType.External_HDD)
        {
            partitions = new Partition[partitionsQuantity];

            this.usbType = usbType;
            for (int i = 0; i < partitionsQuantity; i++)
                partitions[i] = new Partition(size / partitionsQuantity);

        }


        public override double GetReadSpeed()
        {
            return usbType.ReadSpeed / 1024;
        }

        public override double GetWriteSpeed()
        {
            return usbType.WriteSpeed / 1024;
        }

        public override int CopyDataToDevice(Data data)
        {
            double copiedSize = 0;

            for (int i = 0; i < partitions.Length; i++)
            {
                while (partitions[i].EmptyCapacity >= data[data.NumberOfCopiedFiles].Size
                    && data.NumberOfCopiedFiles != data.TotalFilesQuantity)
                {
                    copiedSize += data[data.NumberOfCopiedFiles].Size;
                    partitions[i].EmptyCapacity -= data[data.NumberOfCopiedFiles].Size;

                    Array.Resize(ref partitions[i].filesOnPartition, partitions[i].filesOnPartition.Length + 1);
                    partitions[i].filesOnPartition[partitions[i].filesOnPartition.Length - 1] = data[data.NumberOfCopiedFiles++];
                }
            }

            return (int)(copiedSize / usbType.WriteSpeed);
        }

        public override double GetCapacity()
        {
            double capacity = 0;
            for (int i = 0; i < partitions.Length; i++)
                capacity += partitions[i].Capacity;

            return capacity;
        }

        public override double GetEmptyCapacity()
        {
            double emptyCapacity = 0;
            for (int i = 0; i < partitions.Length; i++)
                emptyCapacity += partitions[i].EmptyCapacity;

            return emptyCapacity;
        }

        public override string GetDeviceInfo()
        {
            return string.Format("Тип носителя и модель: {0}-{1}\nОбъем носителя: {2} Gb" +
             "\nСвободный объем: {3} Gb\nКоличество разделов: {4}\nСкорость (чтение/запись): {5} / {6} Kb/s",
                StorageType, Model, GetCapacity() / 1024, GetEmptyCapacity() / 1024, partitions.Length, usbType.ReadSpeed, usbType.WriteSpeed);
        }
    }
}
