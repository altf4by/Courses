﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class TXTHandler:AbstractHandler
    {
        public override void Save()
        {
            Console.WriteLine("Document is saved in XML");
        }
    }
}
