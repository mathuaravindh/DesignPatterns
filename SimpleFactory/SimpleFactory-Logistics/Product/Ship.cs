using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Product
{
    internal class Ship : ILogistics
    {
        public Int32 TimeTaken { get; set; } = 5;
        public void Deliver()
        {
            Console.WriteLine("Delivering through Sea with the help of ship!");
        }
    }
}
