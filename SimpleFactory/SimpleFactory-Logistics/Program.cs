// See https://aka.ms/new-console-template for more information
using SimpleFactory.Factory;
using SimpleFactory.Product;

Console.WriteLine("Hello, From clent!");

ILogistics roadways = LogisticsFactory.getInstance("Road");
roadways.Deliver();

//Default method implemented in ILogistics.
roadways.Print("Delivery Completed by road in " + roadways.TimeTaken + " days!");

ILogistics seaways = LogisticsFactory.getInstance("Sea");
seaways.Deliver();

//Default method implemented in ILogistics
seaways.Print("Delivery Completed by sea in " + seaways.TimeTaken + " days!");






