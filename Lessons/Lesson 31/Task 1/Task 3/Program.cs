using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_31
{
    public sealed class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public event EventHandler Modified;

        private void OnModified()
        {
            var handler = Modified;
            if (handler != null) handler.Invoke(this, EventArgs.Empty);
        }

        public void Save()
        {

        }
    }

    static class Program
    {
        static void Main()
        {
            var personType = typeof(Person);

            TypeInfo personInfo = personType.GetTypeInfo();

            IEnumerable<PropertyInfo> declaredProperties = personInfo.DeclaredProperties;
            declaredProperties.PrintValues();

            IEnumerable<MethodInfo> declaredMethods = personInfo.DeclaredMethods;
            declaredMethods.PrintValues();

            IEnumerable<EventInfo> declaredEvents = personInfo.DeclaredEvents;
            declaredEvents.PrintValues();

            Console.ReadKey();
        }

        private static void PrintValues(this IEnumerable<MemberInfo> members)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(members.GetType().GetElementType().Name);
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var member in members)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine(new string('-', 20));
        }
    }

}
