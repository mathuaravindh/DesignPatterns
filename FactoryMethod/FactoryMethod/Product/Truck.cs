using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class Truck : ITransport
    {
        public Int16 TimeTaken { get; set; } = 5;
        public Int32 CostPerTon { get; set; } = 25000;

        public void Deliver()
        {
            Console.WriteLine("Develivering through Truck!");
        }

        public int GetCost(Int32 weight)
        {
            return weight * CostPerTon;
        }
    }
}
