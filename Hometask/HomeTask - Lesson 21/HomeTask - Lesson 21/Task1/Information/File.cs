namespace Task1.Information
{
    class File
    {
        public double Size { get; set; }

        public File() : this(780) { }
 
        public File(double size)
        {
            Size = size;
        }
    }
}
