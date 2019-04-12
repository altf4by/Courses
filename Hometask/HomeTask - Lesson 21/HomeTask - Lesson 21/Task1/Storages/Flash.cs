using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Enums;
using Task1.Data;
using Task1.USBIntefaces;

namespace Task1.Storages
{
    class Flash : Storage
    {
        public double Capacity { get; set; }
        protected IUSB_Interface usbType;

        public Flash() : this("NO NAME", 4, new USB_3_0()) { }

        public Flash(double capacity) : this("NO NAME", capacity, new USB_3_0()) { }

        public Flash(string model, double capacity, IUSB_Interface usbType) : base(model, StorageType.Flash)
        {            
            Capacity = capacity;
            this.usbType = usbType;
            EmptyCapacity = Capacity;
        }



        public override void CopyDataToDevice(User user)
        {
            double copiedSize = 0;

            while (EmptyCapacity >= user.infoOnPC[user.NumberOfFileToCopy].Size && user.NumberOfFileToCopy != user.infoOnPC.TotalFilesQuantity)
            {
                EmptyCapacity -= user.infoOnPC[user.NumberOfFileToCopy++].Size;
                copiedSize += user.infoOnPC[user.NumberOfFileToCopy].Size;
            }
            user.TimeSpent += (int)(copiedSize / usbType.WriteSpeed);
        }

        public void CopyFileToDevice(File file)
        {
            double copiedSize = 0;

            while (EmptyCapacity >= file.Size)
            {
                EmptyCapacity -= file.Size;
                copiedSize += file.Size;
            }
        }

        public override double GetCapacity()
        {
            return Capacity;
        }

        public override double GetEmptyCapacity()
        {
            return EmptyCapacity;
        }

        public override string GetDeviceInfo()
        {
            return string.Format("Тип носителя и модель: {0}-{1}\nОбъем носителя: {2} Gb" +
                                 "\nСвободный объем: {3} Gb\nСкорость (чтение/запись): {4} / {5} Kb/s",
                StorageType, Model, Capacity, EmptyCapacity, usbType.ReadSpeed, usbType.WriteSpeed);
        }
    }
}
