using Task1.DVDInterfaces;
using Task1.Enums;

namespace Task1.Storages
{
    class DVD : Storage
    {
        public const double ReadSpeed = 10.56 * 1024;
        public const double WriteSpeed = 10.56 * 1024;

        public DVDSide[] sides; 

        protected IDVD_Interface dvdType;

        public DVD() : this("ACME 003237", new OneSideDVD()) { }

        public DVD(string model, IDVD_Interface dvdType) : base(model, StorageType.DVD)
        {
            this.dvdType = dvdType;

            sides = new DVDSide[dvdType.SidesQuantity];

            for (int i = 0; i <= dvdType.SidesQuantity-1; i++)
                sides[i] = new DVDSide();

            EmptyCapacity = dvdType.SidesQuantity*sides[0].GetSideCapacity();
        }


        public override void CopyDataToDevice(User user)
        {
            for (int i = 0; i < dvdType.SidesQuantity - 1; i++)
            {
                double copiedSize = 0;

                while (sides[i].EmptyCapacity >= user.infoOnPC[user.FileNumberToCopy].Size 
                    && user.FileNumberToCopy != user.infoOnPC.TotalFilesQuantity)
                {
                    sides[i].EmptyCapacity -= user.infoOnPC[user.FileNumberToCopy++].Size;
                    copiedSize += user.infoOnPC[user.FileNumberToCopy].Size;
                    user.TimeSpent += (int)(copiedSize / WriteSpeed);
                }
            }  
        }

        public override double GetCapacity()
        {
            return dvdType.SidesQuantity * sides[0].GetSideCapacity();
        }

        public override double GetEmptyCapacity()
        {
            return EmptyCapacity;
        }

        public override string GetDeviceInfo()
        {
            return string.Format("Тип носителя и модель: {0}-{1}\nОбъем носителя: {2} Gb" +
             "\nСвободный объем: {3} Gb\nКоличество сторон: {4}\nСкорость (чтение/запись): {5} / {6} Kb/s",
                StorageType, Model, this.GetCapacity(), EmptyCapacity, dvdType.SidesQuantity, ReadSpeed, WriteSpeed);
        }
    }
}
