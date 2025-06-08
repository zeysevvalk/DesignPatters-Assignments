using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class PencilSharpener : IPencilSharpener
    {
        public void Sharpen(IPencil pencil)
        {
            pencil.AfterSharpening();
            Console.WriteLine("Pencil has been sharpened.");
        }
    }
}
