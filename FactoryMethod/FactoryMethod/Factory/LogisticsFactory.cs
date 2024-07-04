using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public abstract class LogisticsFactory
    {
        double surchargePerTon = 1.75;

        public LogisticsFactory() 
        {

        }
        public abstract ITransport CreateTransport();

        public void PrintCost(Int32 weight)
        {
            ITransport transport = CreateTransport();
            int cost = transport.GetCost(weight);
            double totalCost = surchargePerTon * cost;
            Console.WriteLine("Cost for " + weight + " ton is " + totalCost + " including surcharges!");
        }
    }
}
