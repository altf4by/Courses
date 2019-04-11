using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4__date_
{
    class Date
    {

        public Date(DateTime dt)
        {
            DateTime = dt;
        }
        public DateTime DateTime { get; set; }

        public static int operator- (Date date1, Date date2)
        {
            return (date1.DateTime - date2.DateTime).Days;
        }
    }
}
