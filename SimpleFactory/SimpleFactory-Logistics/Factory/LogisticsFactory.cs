using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Factory
{
    public class LogisticsFactory
    {
        internal static ILogistics getInstance(string type)
        {
            if (type == "Road")
                return new Truck();
            else if (type == "Sea")
                return new Ship();
            else        
                return null;
        }
    }
}
