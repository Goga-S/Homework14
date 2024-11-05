using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Abstractions;

namespace task1.Products
{
    public class VictorianChair : IChair
    {
        public void getChair()
        {
            Console.WriteLine("Victorian chair");
        }
    }

    public class VictorianSofa : ISofa
    {
        public void getSofa()
        {
            Console.WriteLine("Victorian sofa");
        }
    }

    public class VictorianCoffeeTable : ICoffeeTable
    {
        public void getTable()
        {
            Console.WriteLine("Victorian Coffee table");
        }
    }
}
