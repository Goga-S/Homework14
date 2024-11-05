using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Abstractions;

namespace task1.Products
{
    public class ArtDecoChair : IChair
    {
        public void getChair()
        {
            Console.WriteLine("ArtDeco Chair");
        }

    }

    public class ArtDecoCoffeeTable : ICoffeeTable
    {
        public void getTable()
        {
            Console.WriteLine("ArtDeco table");
        }
    }

    public class ArtDecoSofa : ISofa
    {
        public void getSofa()
        {
            Console.WriteLine("ArtDeco sofa");
        }
    }
}
