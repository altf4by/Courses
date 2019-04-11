using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_5
{
    class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empiD, float currPay, string ssn, int numbOfSales)
        : base(fullName, age, empiD, currPay, ssn, numbOfSales)
        {
        }

        
    }
}
