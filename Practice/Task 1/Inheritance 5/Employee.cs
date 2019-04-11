using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_5
{
    abstract class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public float Pay { get; set; }
        public string SocialSecurityNumber { get; set; }
        protected BenefitPackage empBenefits = new BenefitPackage();


        //protected string empName;
        //protected int empID;
        //protected float currPay;
        //protected int empAge;
        protected string empSSN;


        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }
        public Employee(string name, int age, int id, float pay, string ssn) : this(name, age, id, pay)
        {
            empSSN = ssn;
        }
        public Employee()
        {
        }


        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeducation();
        }
        public BenefitPackage Benefit
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", empSSN);
        }

        public class BenefitPackage
        {
            public double ComputePayDeducation()
            {
                return 125.0;
            }
        }
    }
}
