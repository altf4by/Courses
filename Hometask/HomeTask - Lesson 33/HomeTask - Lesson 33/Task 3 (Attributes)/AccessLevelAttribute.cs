using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3__Attributes_
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class AccessLevelAttribute : Attribute
    {
        public enum AccessLevel : byte { Full, Partial, Denied }

        private readonly AccessLevel accessLevel;

        public AccessLevel Access { get => accessLevel; }

        public AccessLevelAttribute(AccessLevel accessLevel)
        {
            this.accessLevel = accessLevel;
        }

    }
}
