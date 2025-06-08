using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Logger
    {
        private static Logger uniqueInstance;
        private int numberOfLines = 0;

        private Logger() { }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }
            return uniqueInstance;
        }

        public void Log(string source, string message)
        {
            numberOfLines++;
            Console.WriteLine($"{numberOfLines} - [{source}] {message}");
        }
    }
}
