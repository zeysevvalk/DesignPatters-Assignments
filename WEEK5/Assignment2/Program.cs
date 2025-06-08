using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            new Program().Start();
        }

        void Start()
        {
            ATMMachine machine = new ATMMachine(2000);

            Console.WriteLine("ATM Machine Started");
            Console.WriteLine("Available commands: 'insert card', 'reject card', 'enter pincode', 'withdraw cash', 'stop'");
            Console.WriteLine($"Initial ATM balance: €{machine.AmountInMachine}");
            Console.WriteLine();

            string command;
            do
            {
                Console.Write("Enter command: ");
                command = Console.ReadLine()?.ToLower().Trim();

                switch (command)
                {
                    case "insert card":
                        machine.InsertCard();
                        break;
                    case "reject card":
                        machine.RejectCard();
                        break;
                    case "enter pincode":
                        machine.EnterPincode();
                        break;
                    case "withdraw cash":
                        machine.WithdrawCash();
                        break;
                    case "stop":
                        Console.WriteLine("ATM shutting down...");
                        break;
                    default:
                        if (!string.IsNullOrEmpty(command))
                            Console.WriteLine("Invalid command. Valid commands: 'insert card', 'reject card', 'enter pincode', 'withdraw cash', 'stop'");
                        break;
                }
                Console.WriteLine();
            }
            while (command != "stop");
        }
    }
}