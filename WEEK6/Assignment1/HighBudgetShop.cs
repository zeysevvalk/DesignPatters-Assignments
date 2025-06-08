using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment1.HighBudgetComponents;

namespace Assignment1
{
    public class HighBudgetShop : ComputerShop
    {
        protected override IProcessor CreateProcessor()
        {
            return new HighEndProcessor();
        }

        protected override IHardDisk CreateHardDisk()
        {
            return new HighEndHardDisk();
        }

        protected override IMonitor CreateMonitor()
        {
            return new HighEndMonitor();
        }

    }
}
