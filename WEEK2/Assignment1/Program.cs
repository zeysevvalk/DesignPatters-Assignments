using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            BatchProcessor processor = new BatchProcessor();
            processor.AddLoader(new CallDataLoader());
            processor.AddLoader(new TwitterDataLoader());
            processor.AddLoader(new SensorDataLoader());


            processor.ProcessAll();
        }
    }
}