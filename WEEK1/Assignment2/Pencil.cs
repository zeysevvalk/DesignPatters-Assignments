using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Pencil : IPencil
    {
        private int maxToWrite; // number of characters to write with a sharpened pencil
        private int nrOfCharsWritten = 0; // number of written characters

        public Pencil(int maxToWrite)
        {
            this.maxToWrite = maxToWrite;
        }

        public bool CanWrite => nrOfCharsWritten < maxToWrite;

        public void Write(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                if (nrOfCharsWritten < maxToWrite)
                {
                    Console.Write(message[i]);
                }
                else
                {
                    Console.Write('#');
                }
                nrOfCharsWritten++;
            }
            Console.WriteLine();
        }

        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;
        }
    }
}
