using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Enums;
using Task1.USBIntefaces;

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


        public override void CopyDataToDevice(User user)
        {
            for (int i = 0; i < partitions.Length; i++)
            {
                double copiedSize = 0;

                while (partitions[i].EmptyCapacity >= user.infoOnPC[user.NumberOfFileToCopy].Size
                    && user.NumberOfFileToCopy != user.infoOnPC.TotalFilesQuantity)
                {
                    partitions[i].EmptyCapacity -= user.infoOnPC[user.NumberOfFileToCopy++].Size;
                    copiedSize += user.infoOnPC[user.NumberOfFileToCopy].Size;
                    user.TimeSpent += (int)(copiedSize / usbType.WriteSpeed);
                }
            }
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
                StorageType, Model, GetCapacity()/1024, EmptyCapacity/1024, partitions.Length, usbType.ReadSpeed, usbType.WriteSpeed);
        }
    }
}
