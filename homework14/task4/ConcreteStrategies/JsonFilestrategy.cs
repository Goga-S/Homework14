using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.ConcreteStrategies
{
    public class JsonFilestrategy : FileHandlingStrategy
    {
        public override void manageFile()
        {
            Console.WriteLine("print file content in a console");
        }
    }
}
