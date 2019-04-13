namespace Task1.USBIntefaces
{
    class USB_3_0:IUSB_Interface
    {
        public double ReadSpeed { get { return 85 * 1024; } }
        public double WriteSpeed { get { return 55 * 1024; } }
    }
}
