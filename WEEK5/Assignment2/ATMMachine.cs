using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ATMMachine
    {
        private double amountInMachine;
        private bool cardPresent;
        private bool correctPinCode;
        private bool noCash;
        private IATMState machineState;

        // State instances
        private IATMState noCardState;
        private IATMState cardPresentState;
        private IATMState correctPinState;
        private IATMState noCashState;

        // Constructor
        public ATMMachine(double amount)
        {
            amountInMachine = amount;
            cardPresent = false;
            correctPinCode = false;
            noCash = amount <= 0;

            // Initialize states
            noCardState = new NoCardState();
            cardPresentState = new CardPresentState();
            correctPinState = new CorrectPinState();
            noCashState = new NoCashState();

            // Set initial state
            if (noCash)
                machineState = noCashState;
            else
                machineState = noCardState;
        }

        // Properties
        public double AmountInMachine
        {
            get { return amountInMachine; }
            set { amountInMachine = value; }
        }

        // Methods
        public void InsertCard()
        {
            machineState.InsertCard(this);
        }

        public void RejectCard()
        {
            machineState.RejectCard(this);
        }

        public void EnterPincode()
        {
            machineState.EnterPincode(this);
        }

        public void WithdrawCash()
        {
            machineState.WithdrawCash(this);
        }

        public void SetMachineState(IATMState state)
        {
            machineState = state;
        }

        // State getters
        public IATMState GetNoCardState()
        {
            return noCardState;
        }

        public IATMState GetCardPresentState()
        {
            return cardPresentState;
        }

        public IATMState GetCorrectPinState()
        {
            return correctPinState;
        }

        public IATMState GetNoCashState()
        {
            return noCashState;
        }

        public void SetAmountInMachine(double amount)
        {
            amountInMachine = amount;
            if (amountInMachine <= 0)
            {
                noCash = true;
                machineState = noCashState;
            }
            else
            {
                noCash = false;
            }
        }
    }
}
