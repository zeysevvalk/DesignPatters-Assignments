using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Robot
    {
        private string person;
        public string Person => person; // Read-only property

        public void MoveByPerson(string personName)
        {
            person = personName;
            Console.WriteLine($"Robot is moved by {personName}");
        }

        public void WalkForward()
        {
            Console.WriteLine("Robot walks forward");
        }

        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }

    }
}
