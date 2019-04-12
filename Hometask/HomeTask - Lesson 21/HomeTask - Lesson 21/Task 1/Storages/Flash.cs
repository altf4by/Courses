using System;
using System.Collections.Generic;
using Task_1.Enums;

namespace Task_1.Storages
{
    class Flash : Storage
    {
        public Flash(int readSpeed, int writeSpeed)
        {
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
            StorageType = StorageTypes.FLASH;
        }

    }
}
