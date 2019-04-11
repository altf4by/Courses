using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Teacher : Person
    {
        public string SkillLevel { get; set; }
        public Teacher(string firstName, string secondName,string skillLevel) : base(firstName, secondName)
        {
            SkillLevel = skillLevel;
        }
        public override void SayHello()
        {
            Console.WriteLine("Hello from teacher {0}", FullName);
        }
    }
}
