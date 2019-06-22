using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class ClassA
    {
        private int _number;
        private ClassB classB;
        public int NNN { get; set; }

        public ClassA()
        {
            _number = 5;
            classB = new ClassB();
            classB.Method(2, 4);
        }

        public ClassA DeepCopy()
        {

            var copy = new ClassA();


            Type type = GetType();
            var deepCopy = Activator.CreateInstance(type);
            List<object> values = new List<object>();
            Dictionary<FieldInfo, object> data = new Dictionary<FieldInfo, object>();


            foreach (var field in type.GetFields())
                data.Add(field, field.GetValue(this));

                

            foreach (var item in data)
            {
                foreach (var f in deepCopy.GetType().GetFields())
                {
                    if (f.Name == item.Key.Name)
                    {
                        var name = f.Name;
                        f.SetValue(item, item.Value);
                    }
                }
            }

            var value = type.GetField("classB")?.GetValue(this);

            return deepCopy as ClassA;
        }
    }
}
