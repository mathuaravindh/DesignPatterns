// See https://aka.ms/new-console-template for more information
using FactoryMethod.Factory;
using FactoryMethod.Product;

Console.WriteLine("Hello! From Client");

LogisticsFactory logisticsFactory = new ShipFactory();

//calls concretefactory to create objects
ITransport transport = logisticsFactory.CreateTransport();
transport.Deliver();

//call common business logic in Abstract factory
logisticsFactory.PrintCost(5);

//Default implementation from interface
transport.PrintDeliveryStatus("Delivered Successfully through Ship in " + transport.TimeTaken + " days!");

Console.WriteLine(Environment.NewLine);

logisticsFactory = new TruckFactory();
transport = logisticsFactory.CreateTransport();
transport.Deliver();
logisticsFactory.PrintCost(5);

transport.PrintDeliveryStatus("Delivered Successfully through Truck in " + transport.TimeTaken + " days!");
