﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TwitterDataLoader : BigDataLoader
    {
        protected override void Extract()
        {
            Console.WriteLine("extracting twitter data...");
        }

        protected override void Transform()
        {
            Console.WriteLine("transforming twitter data...");
        }
    }
}
