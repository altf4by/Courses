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
            Capacity = capacity*1024;
            this.usbType = usbType;
            EmptyCapacity = Capacity;
        }



        public override void CopyDataToDevice(User user)
        {
            double copiedSize = 0;
            
            while (EmptyCapacity >= user.infoOnPC[user.FileNumberToCopy].Size && user.FileNumberToCopy != user.infoOnPC.TotalFilesQuantity)
            {
                EmptyCapacity -= user.infoOnPC[user.FileNumberToCopy++].Size;
                copiedSize += user.infoOnPC[user.FileNumberToCopy].Size;
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
                StorageType, Model, Capacity/1024, EmptyCapacity/1024, usbType.ReadSpeed, usbType.WriteSpeed);
        }
    }
}
