using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Abstractions;
using task1.Products;

namespace task1.Creator
{
    internal class ModernFactory : IFactory
    {
        public IChair createChair()
        {
            return new ModernChair();
        }

        public ICoffeeTable createCoffeeTable()
        {
            return new ModernCoffeTable();
        }

        public ISofa createSofa()
        {
            return new ModernSofa();
        }
    }
}
