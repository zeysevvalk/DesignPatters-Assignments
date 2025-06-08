using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ExpensiveComponents
    {
        public class HighEndProcessor : IProcessor
        {
            public void PerformOperation()
            {
                Console.WriteLine("performing operation very quickly...");
            }
        }

        // High-end HardDisk
        public class HighEndHardDisk : IHardDisk
        {
            public void StoreData()
            {
                Console.WriteLine("storing data very quickly...");
            }
        }

        // High-end Monitor
        public class HighEndMonitor : IMonitor
        {
            public void Display()
            {
                Console.WriteLine("displaying stuff very nice...");
            }
        }
    }
}
