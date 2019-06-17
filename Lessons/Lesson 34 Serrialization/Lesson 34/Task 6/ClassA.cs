using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    [Serializable]
    class ClassA
    {
        private int _number;
        private ClassB classB;

        public ClassA()
        {
        }

        public ClassA DeepCopy()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(ms, this);
            //ms.Close();

            //MemoryStream ms2 = new MemoryStream();
            ms.Position = 0;

            return bf.Deserialize(ms) as ClassA;
        }
    }
}
