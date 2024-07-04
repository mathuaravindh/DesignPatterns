using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public interface ITransport
    {
        Int16 TimeTaken { get; set; }

        public void Deliver();

        public int GetCost(Int32 weight);

        public void PrintDeliveryStatus(string deliveryStatus)
        {
            Console.WriteLine(deliveryStatus);
        }
    }
}
