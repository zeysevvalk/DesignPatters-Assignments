using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class LowBudgetFactory : IComputerFactory
    {
        public IProcessor CreateProcessor()
        {
            return new CheapComponents.LowEndProcessor();
        }

        public IHardDisk CreateHardDisk()
        {
            return new CheapComponents.LowEndHardDisk();
        }

        public IMonitor CreateMonitor()
        {
            return new CheapComponents.LowEndMonitor();
        }
    }
}
