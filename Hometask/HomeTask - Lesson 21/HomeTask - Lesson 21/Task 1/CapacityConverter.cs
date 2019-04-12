namespace Task_1
{
    static class CapacityConverter
    {
        public static int ConvertToKBytes(int capacityInBytes)
        {
            return capacityInBytes / 1024;
        }

        public static int ConvertToMBytes(int capacityInBytes)
        {
            return ConvertToKBytes(capacityInBytes) / 1024;
        }

        public static int ConvertToGbytes(int capacityInBytes)
        {
            return ConvertToMBytes(capacityInBytes) / 1024;
        }


        public static int ConvertFromKbytes(double capacityInKbytes)
        {
            return (int)(capacityInKbytes * 1024);
        }

        public static double ConvertFromMbytes(double capacityInMBytes)
        {
            return ConvertFromKbytes(capacityInMBytes*1024);
        }

        public static double ConvertFromGBytes(double capacityInGbytes)
        {
            return ConvertFromMbytes(capacityInGbytes * 1024);
        }
    }
}
