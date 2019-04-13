using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Data
{
    class Information
    {
        double size;
        File[] files;
        public int TotalFilesQuantity { get; set; }

               
        public Information(double size)
        {
            this.size = size*1024;
            TotalFilesQuantity = (int)(this.size / new File().Size);
            files = new File[TotalFilesQuantity];
        }

        public File this[int index]
        {
            get { return files[index]; }
        }

    }
}
