using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class NoCardState : IATMState
    {
        public void InsertCard(ATMMachine machine)
        {
            Console.WriteLine("Card inserted. Please enter your PIN code.");
            machine.SetMachineState(machine.GetCardPresentState());
        }

        public void RejectCard(ATMMachine machine)
        {
            Console.WriteLine("No card to reject.");
        }

        public void EnterPincode(ATMMachine machine)
        {
            Console.WriteLine("Please insert card first.");
        }

        public void WithdrawCash(ATMMachine machine)
        {
            Console.WriteLine("Please insert card first.");
        }
    }
}
