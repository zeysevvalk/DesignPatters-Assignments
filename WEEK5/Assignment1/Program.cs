using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            new Program().Start();
        }

        void Start()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("Program", "Starting the application");
            MainSystem mainSystem = new MainSystem();
            logger.Log("Program", "Application finished");
        }
    }
}