﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.ConcreteStrategies
{
    public class TxtFilestrategy : FileHandlingStrategy
    {
        public override void manageFile()
        {
            Console.WriteLine("delete txt file");
        }
    }
}
