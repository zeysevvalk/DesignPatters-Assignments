using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class HighBudgetFactory : IComputerFactory
    {
        public IProcessor CreateProcessor()
        {
            return new ExpensiveComponents.HighEndProcessor();
        }

        public IHardDisk CreateHardDisk()
        {
            return new ExpensiveComponents.HighEndHardDisk();
        }

        public IMonitor CreateMonitor()
        {
            return new ExpensiveComponents.HighEndMonitor();
        }
    }
}
