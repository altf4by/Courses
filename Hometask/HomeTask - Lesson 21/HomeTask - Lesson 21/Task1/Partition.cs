﻿
namespace Task1
{
    class Partition
    {
        public double Capacity { get; set; }
        public double EmptyCapacity { get; set; }

        public Partition() : this(166.66 * 1024) { }

        public Partition(double size) { Capacity = size; EmptyCapacity = size; }

    }
}
