using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Computer
    {
        private IProcessor processor;
        private IHardDisk hardDisk;
        private IMonitor monitor;

        // Constructor
        public Computer(IProcessor processor, IHardDisk hardDisk, IMonitor monitor)
        {
            this.processor = processor;
            this.hardDisk = hardDisk;
            this.monitor = monitor;
        }

        // Test method that calls all component methods
        public void Test()
        {
            processor.PerformOperation();
            hardDisk.StoreData();
            monitor.Display();
        }
    }
}
