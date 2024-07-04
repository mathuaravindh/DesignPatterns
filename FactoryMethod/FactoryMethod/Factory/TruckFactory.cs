﻿using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class TruckFactory : LogisticsFactory
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
