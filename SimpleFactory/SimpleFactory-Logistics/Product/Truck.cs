using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Product
{
    internal class Truck : ILogistics
    {
        public Int32 TimeTaken { get; set; } = 10;
        public void Deliver()
        {
            Console.WriteLine("Delivering through Road with the help of truck!");
        }
    }
}
