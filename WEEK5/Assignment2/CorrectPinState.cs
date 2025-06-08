using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class CorrectPinState : IATMState
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
            Console.WriteLine("PIN already entered correctly.");
        }

        public void WithdrawCash(ATMMachine machine)
        {
            if (machine.AmountInMachine >= 50) // Assume minimum withdrawal of 50
            {
                double withdrawAmount = 50; // Fixed amount for simplicity
                machine.SetAmountInMachine(machine.AmountInMachine - withdrawAmount);
                Console.WriteLine($"Cash withdrawn: €{withdrawAmount}. Remaining in machine: €{machine.AmountInMachine}");

                if (machine.AmountInMachine <= 0)
                {
                    Console.WriteLine("ATM is out of cash.");
                    machine.SetMachineState(machine.GetNoCashState());
                }
                else
                {
                    Console.WriteLine("Transaction complete. Card ejected.");
                    machine.SetMachineState(machine.GetNoCardState());
                }
            }
            else
            {
                Console.WriteLine("Insufficient funds in ATM.");
                machine.SetMachineState(machine.GetNoCashState());
            }
        }
    }
}
