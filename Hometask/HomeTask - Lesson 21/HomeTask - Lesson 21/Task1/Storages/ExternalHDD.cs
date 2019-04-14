using Task1.Enums;
using Task1.USBIntefaces;
using System;

namespace Task1.Storages
{
    class ExternalHDD : Storage
    {
        Partition[] partitions;
        protected IUSB_Interface usbType;


        public ExternalHDD() : this("Seagate ST905004EXA101-RK", 3, new USB_2_0()) { }

        public ExternalHDD(string model, int partiotionsQuantity, IUSB_Interface usbType) : base(model, StorageType.External_HDD)
        {
            partitions = new Partition[partiotionsQuantity];

            this.usbType = usbType;
            for (int i = 0; i < partiotionsQuantity; i++)
                partitions[i] = new Partition();

            EmptyCapacity = GetEmptyCapacity();
        }


        public override double GetReadSpeed()
        {
            return usbType.ReadSpeed/1024;
        }

        public override double GetWriteSpeed()
        {
            return usbType.WriteSpeed/1024;
        }

        public override int CopyDataToDevice(User user)
        {
            double copiedSize = 0;

            for (int i = 0; i < partitions.Length; i++)
            {
                while (partitions[i].EmptyCapacity >= user.infoOnPC[user.FileNumberToCopy].Size
                    && user.FileNumberToCopy != user.infoOnPC.TotalFilesQuantity)
                {
                    copiedSize += user.infoOnPC[user.FileNumberToCopy].Size;
                    partitions[i].EmptyCapacity -= user.infoOnPC[user.FileNumberToCopy].Size;
                    Array.Resize(ref filesOnDevice, filesOnDevice.Length + 1);
                    filesOnDevice[filesOnDevice.Length - 1] = user.infoOnPC[user.FileNumberToCopy++];
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

            for (int i = 0; i < partitions.Length; i++)
                EmptyCapacity += partitions[i].EmptyCapacity;

            return EmptyCapacity;
        }

        public override string GetDeviceInfo()
        {
            return string.Format("Тип носителя и модель: {0}-{1}\nОбъем носителя: {2} Gb" +
             "\nСвободный объем: {3} Gb\nКоличество разделов: {4}\nСкорость (чтение/запись): {5} / {6} Kb/s",
                StorageType, Model, GetCapacity() / 1024, EmptyCapacity / 1024, partitions.Length, usbType.ReadSpeed, usbType.WriteSpeed);
        }
    }
}
