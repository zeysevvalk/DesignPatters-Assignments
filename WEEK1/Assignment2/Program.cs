using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPencil pencil = new Pencil(10); 
            IPencilSharpener sharpener = new PencilSharpener();

            while (true)
            {
                Console.Write("Enter a message (or type 'sharpen' or 'stop'): ");
                string input = Console.ReadLine()!;

                if (input.ToLower() == "stop")
                    break;
                else if (input.ToLower() == "sharpen")
                    sharpener.Sharpen(pencil);
                else
                    pencil.Write(input);
            }

        }
        
    }
}
