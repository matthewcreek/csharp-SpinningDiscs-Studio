using System;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public string Resolution { get; set; }
        public DVD(double storageCapacity, double spinningSpeed, double writeSpeed, double readSpeed, string readWriteMethod, Dictionary<string, string> data, string resolution) : base(storageCapacity, spinningSpeed, writeSpeed, readSpeed, readWriteMethod, data)
        {
            Resolution = resolution;
        }

        public void SpinDisc()
        {
            Console.WriteLine($"Spinning disc up to {SpinningSpeed} RPM...");
        }
        public void ReadData()
        {
            Console.WriteLine("Reading data...");
            foreach (KeyValuePair<string,string> dataSet in Data)
            {
                Console.WriteLine($"The {dataSet.Key} is {dataSet.Value}");
            }
        }
        public void WriteData(string key, string value)
        {
            Console.WriteLine("Writing data...");
            Data.Add(key, value);
        }
    }
}

