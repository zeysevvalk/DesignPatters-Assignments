using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public interface IAttacker
    {
        string Driver { get; } // Read-only
        void AssignDriver(string driverName);
        void DriveForward();
        void UseWeapon();
    }
}
