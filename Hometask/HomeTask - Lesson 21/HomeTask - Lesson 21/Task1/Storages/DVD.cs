using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DVDInterfaces;
using Task1.Enums;

namespace Task1.Storages
{
    class DVD : Storage
    {
        public const double ReadSpeed = 10.56 * 1024;
        public const double WriteSpeed = 10.56 * 1024;

        protected IDVD_Interface dvdType;


        public DVD() : this("No Name", new OneSideDVD()) { }

        public DVD(string model, IDVD_Interface dvdType) : base(model, StorageType.DVD)
        {
            this.dvdType = dvdType;
            EmptyCapacity = dvdType.SidesQuantity == 1 ? 4.7 : 9.4;
        }

        public override void CopyDataToDevice(User user)
        {
            throw new NotImplementedException();
        }

        public override double GetCapacity()
        {
            return dvdType.SidesQuantity == 1 ? 4.7 : 9.4;
        }

        public override double GetEmptyCapacity()
        {
            return EmptyCapacity;
        }

        public override string GetDeviceInfo()
        {
            return string.Format("Тип носителя и модель: {0}-{1}\nОбъем носителя: {2} Gb" +
             "\nСвободный объем: {3} Gb\nКоличество сторон: {4}\nСкорость (чтение/запись): {5} / {6} Kb/s",
                StorageType, Model, GetCapacity(), EmptyCapacity, dvdType.SidesQuantity, ReadSpeed, WriteSpeed);
        }
    }
}
