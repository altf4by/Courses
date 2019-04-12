using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Enums;
namespace Task_1.Storages
{
    class DVD : Storage
    {
        readonly DVDTypes dvdType;

        public DVD(string model, double readSpeed, double writeSpeed, DVDTypes dvdType)
        {
            Model = model;
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
            StorageType = StorageTypes.DVD;

            CapacityInBytes = (dvdType == DVDTypes.OneSide) ?
                CapacityConverter.ConvertFromGBytes(4.7) :
                CapacityConverter.ConvertFromGBytes(9.6);
            
            this.dvdType = dvdType;
        }
    }
}
