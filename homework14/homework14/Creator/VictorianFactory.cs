using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Abstractions;
using task1.Products;

namespace task1.Creator
{
    public class VictorianFactory : IFactory
    {
        public IChair createChair()
        {
            return new VictorianChair();
        }

        public ICoffeeTable createCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public ISofa createSofa()
        {
            return new VictorianSofa();
        }
    }
}
