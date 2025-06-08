using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class ComputerShop
    {
        protected abstract IProcessor CreateProcessor();
        protected abstract IHardDisk CreateHardDisk();
        protected abstract IMonitor CreateMonitor();

        // Template method that uses factory methods
        public Computer AssembleComputer()
        {
            IProcessor processor = CreateProcessor();
            IHardDisk hardDisk = CreateHardDisk();
            IMonitor monitor = CreateMonitor();

            return new Computer(processor, hardDisk, monitor);
        }
    }
}
