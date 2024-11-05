using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Abstractions;

namespace task1.Products
{
    public class ModernChair : IChair
    {
        public void getChair()
        {
            Console.WriteLine("Modern chair");
        }
    }

    public class ModernSofa : ISofa
    {
        public void getSofa()
        {
            Console.WriteLine("Modern Sofa");
        }
    }

    public class ModernCoffeTable : ICoffeeTable
    {
        public void getTable()
        {
            Console.WriteLine("MOdern Coffee table");
        }
    }
}
