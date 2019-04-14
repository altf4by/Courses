namespace Task1.Data
{
    class Information
    {
        double size;
        File[] files;
        public int TotalFilesQuantity { get; set; }


        public Information(double size)
        {
            this.size = size * 1024;
            double tempFileSize = new File().Size;

            //Здесь я проверяю количество файлов (с учетом того, что последний файл может быть не стандартного размера)
            if (this.size > ((int)(this.size / tempFileSize)) * tempFileSize)
                TotalFilesQuantity = (int)(this.size / tempFileSize) + 1;
            else TotalFilesQuantity = (int)(this.size / tempFileSize);


            files = new File[TotalFilesQuantity];
            for (int i = 0; i < TotalFilesQuantity - 1; i++)
                files[i] = new File();

            files[TotalFilesQuantity - 1] = new File(this.size - ((int)(this.size / tempFileSize)) * tempFileSize);
        }

        public File this[int index]
        {
            get
            {
                if (index >= 0 && index < TotalFilesQuantity)
                    return files[index];
                else return files[TotalFilesQuantity - 1];
            }
        }

    }
}
