using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Abstractions;

namespace task1
{
    public class Application
    {
        private readonly IChair _chair;
        private readonly ISofa _sofa;
        private readonly ICoffeeTable _coffeeTable;

        public Application(IFactory factory)
        {
            _chair = factory.createChair();
            _sofa = factory.createSofa();
            _coffeeTable = factory.createCoffeeTable();
        }

        public void print ()
        {
            _chair.getChair();
            _sofa.getSofa();
            _coffeeTable.getTable();
        }
    }
}
