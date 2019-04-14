namespace Task1.DVDInterfaces
{
    class DVDSide
    {
        private const double _capacity = 4.7;
        public double EmptyCapacity { get; set; }

        public DVDSide()
        {
            EmptyCapacity = _capacity*1024;
        }

        public double GetSideCapacity()
        {
            return _capacity;
        }

    }
}
