using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Information
    {
        File[] allData;
        int filesQuantity;

        public Information(double sizeInGbytes)
        {
            filesQuantity = (int)(CapacityConverter.ConvertFromGBytes(sizeInGbytes) / File.size);
            allData = new File[filesQuantity];
        }


    }
}
