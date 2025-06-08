using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class NoCashState : IATMState
    {
        public void InsertCard(ATMMachine machine)
        {
            Console.WriteLine("ATM is out of service. No cash available.");
        }

        public void RejectCard(ATMMachine machine)
        {
            Console.WriteLine("ATM is out of service. No cash available.");
        }

        public void EnterPincode(ATMMachine machine)
        {
            Console.WriteLine("ATM is out of service. No cash available.");
        }

        public void WithdrawCash(ATMMachine machine)
        {
            Console.WriteLine("ATM is out of service. No cash available.");
        }
    }
}
