using System;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.WriteLine("[shop creating expensive computers]");
            ComputerShop highBudgetShop = new HighBudgetShop();
            Computer expensiveComputer = highBudgetShop.AssembleComputer();
            expensiveComputer.Test();

            Console.WriteLine();

            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            ComputerShop lowBudgetShop = new LowBudgetShop();
            Computer cheapComputer = lowBudgetShop.AssembleComputer();
            cheapComputer.Test();
        }
    }
}