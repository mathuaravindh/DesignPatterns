using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Product
{
    internal interface ILogistics
    {
        //Instance property in interface supported from C# 8.0
        Int32 TimeTaken { get; set; }

        void Deliver();

        //Default method implementation in interface supported from C# 8.0
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
