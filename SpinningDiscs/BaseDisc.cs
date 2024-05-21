namespace SpinningDiscs
{
    public abstract class BaseDisc
    {

        public double StorageCapacity { get; set; }
        public double SpinningSpeed { get; set; }
        public double WriteSpeed { get; set; }
        public double ReadSpeed { get; set; }
        public string ReadWriteMethod { get; set; }
        public Dictionary<string,string> Data { get; set; }
        
        protected BaseDisc(double storageCapacity, double spinningSpeed, double writeSpeed, double readSpeed, string readWriteMethod, Dictionary<string, string> data)
        {
            StorageCapacity = storageCapacity;
            SpinningSpeed = spinningSpeed;
            WriteSpeed = writeSpeed;
            ReadSpeed = readSpeed;
            ReadWriteMethod = readWriteMethod;
            Data = data;
        }
    }
}