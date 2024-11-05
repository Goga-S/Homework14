using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class Context
    {
        FileHandlingStrategy _strategy;

        public Context(FileHandlingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.manageFile();
        }
    }
}
