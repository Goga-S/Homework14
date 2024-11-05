using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Abstractions;
using task1.Products;

namespace task1.Creator
{
    public class ArtDecoFactory : IFactory
    {
        public IChair createChair()
        {
            return new ArtDecoChair();
        }

        public ICoffeeTable createCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }

        public ISofa createSofa()
        {
            return new ArtDecoSofa();
        }
    }
}
