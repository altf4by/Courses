using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    struct Worker
    {
        public string LastName { get; set; }
        string position;
        DateTime yearOfEmployment;

        public int Experience { get { return (DateTime.Now - yearOfEmployment).Days / 365; } }


        public Worker(string lastName, string position, int yearOfEmployment)
        {
            LastName = lastName;
            this.position = position;
            this.yearOfEmployment = new DateTime(yearOfEmployment, 1, 1);
        }

        public string Display()
        {
            return string.Format("Worker {0} working as {1} for {2} years", this.lastName, this.position, this.Experience);
        }
    }
}
