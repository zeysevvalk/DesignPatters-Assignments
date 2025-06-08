using System;

namespace Assignment2
{
    class Program
    {
        public static void Main()
        {
            Start();
        }

        public static void Start()
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            IComputerFactory highBudgetFactory = new HighBudgetFactory();
            ComputerShop expensiveShop = new ComputerShop(highBudgetFactory);
            Computer expensiveComputer = expensiveShop.AssembleComputer();
            expensiveComputer.Test();

            Console.WriteLine();

            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            IComputerFactory lowBudgetFactory = new LowBudgetFactory();
            ComputerShop cheapShop = new ComputerShop(lowBudgetFactory);
            Computer cheapComputer = cheapShop.AssembleComputer();
            cheapComputer.Test();
        }
    }
}