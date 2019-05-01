using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Element<T>
    {
        private T data;

        public T Data
        {
            get { return data; }
            set
            {
                if (value != null)
                    data = value;
                else throw new ArgumentNullException(nameof(value));
            }
        }

        public Element<T> Next { get; set; } = null;
        public Element<T> Prev { get; set; } = null;


        public Element(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString(); 
        }
    }
}
