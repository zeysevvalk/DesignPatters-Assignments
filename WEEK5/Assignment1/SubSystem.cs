using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class SubSystem
    {
        public SubSystem()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("SubSystem", "doing some work");
        }

        public void DoSomeMoreWork()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("SubSystem", "doing some more work");
        }

    }
}
