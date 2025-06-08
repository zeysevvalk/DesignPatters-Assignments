using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ComputerShop
    {
        private IComputerFactory factory;

        // Constructor takes a factory
        public ComputerShop(IComputerFactory factory)
        {
            this.factory = factory;
        }

        // Method to assemble computer using the factory
        public Computer AssembleComputer()
        {
            IProcessor processor = factory.CreateProcessor();
            IHardDisk hardDisk = factory.CreateHardDisk();
            IMonitor monitor = factory.CreateMonitor();

            return new Computer(processor, hardDisk, monitor);
        }
    }
}
