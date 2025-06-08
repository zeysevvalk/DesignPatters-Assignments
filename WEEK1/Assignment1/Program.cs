using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack myStack = new ArrayStack(50);

            AddValues(myStack);
            CheckValues(myStack);
            ProcessValues(myStack);
        }

        static void AddValues(IStack stack)
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int value = random.Next(0, 100);
                stack.Push(value);
                Console.WriteLine($"pushed {value,2}, new count: {stack.Count}");
            }
        }

        static void CheckValues(IStack stack)
        {
            Console.Write("Enter a number to check in the stack: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                bool exists = stack.Contains(value);
                Console.WriteLine($"Contains {value}? {exists}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"popped {value}, new count: {stack.Count}");
            }
        }

    }
}