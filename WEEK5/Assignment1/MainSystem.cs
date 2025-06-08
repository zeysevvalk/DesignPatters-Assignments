using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class MainSystem
    {
        public MainSystem()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("MainSystem", "doing some main work");

            SubSystem subSystem = new SubSystem();
            subSystem.DoSomeMoreWork();
        }
    }
}
