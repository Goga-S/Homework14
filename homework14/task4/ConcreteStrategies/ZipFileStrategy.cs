using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.ConcreteStrategies
{
    public class ZipFileStrategy : FileHandlingStrategy
    {
        public override void manageFile()
        {
            Console.WriteLine("unzip file and save in backup directory");
        }
    }
}
