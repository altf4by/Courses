using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class File
    {
        
        public static double size;

        public File(double fileSizeInMBytes)
        {
            size = CapacityConverter.ConvertFromMbytes(fileSizeInMBytes);
            
        }
    }
}
