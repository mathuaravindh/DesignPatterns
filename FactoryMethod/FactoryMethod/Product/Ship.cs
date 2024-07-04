using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class Ship : ITransport
    {
        public Int16 TimeTaken { get; set; } = 10;

        public Int32 CostPerTon { get; set; } = 50000;

        public void Deliver()
        {
            Console.WriteLine("Develivering through Ship!");
        }

        public int GetCost(Int32 weight)
        {
            return weight * CostPerTon;
        }
    }
}
