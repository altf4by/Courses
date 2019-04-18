using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class CarIsDeadException : ApplicationException
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException()
        {

        }

        public CarIsDeadException(string message, string cause, DateTime time):base(message)
        {
            ErrorTimeStamp = time;
            CauseOfError = cause;
        }


    }
}
