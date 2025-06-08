using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class CardPresentState : IATMState
    {
        public void InsertCard(ATMMachine machine)
        {
            Console.WriteLine("Card already inserted.");
        }

        public void RejectCard(ATMMachine machine)
        {
            Console.WriteLine("Card rejected.");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void EnterPincode(ATMMachine machine)
        {
            Console.WriteLine("PIN code accepted. You can now withdraw cash.");
            machine.SetMachineState(machine.GetCorrectPinState());
        }

        public void WithdrawCash(ATMMachine machine)
        {
            Console.WriteLine("Please enter your PIN code first.");
        }

    }
}
