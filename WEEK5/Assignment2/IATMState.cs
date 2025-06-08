using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface IATMState
    {
        void InsertCard(ATMMachine machine);
        void RejectCard(ATMMachine machine);
        void EnterPincode(ATMMachine machine);
        void WithdrawCash(ATMMachine machine);
    }
}
