using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment1.LowBudgetComponents;

namespace Assignment1
{
    public class LowBudgetShop : ComputerShop
    {
        protected override IProcessor CreateProcessor()
        {
            return new LowEndProcessor();
        }

        protected override IHardDisk CreateHardDisk()
        {
            return new LowEndHardDisk();
        }

        protected override IMonitor CreateMonitor()
        {
            return new LowEndMonitor();
        }
    }
}
