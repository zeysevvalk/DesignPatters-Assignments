using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class CheapComponents
    {
        public class LowEndProcessor : IProcessor
        {
            public void PerformOperation()
            {
                Console.WriteLine("performing operation not so quickly...");
            }
        }

        // Low-end HardDisk
        public class LowEndHardDisk : IHardDisk
        {
            public void StoreData()
            {
                Console.WriteLine("storing data not so quickly...");
            }
        }

        // Low-end Monitor
        public class LowEndMonitor : IMonitor
        {
            public void Display()
            {
                Console.WriteLine("displaying stuff very poor...");
            }
        }
    }
}
