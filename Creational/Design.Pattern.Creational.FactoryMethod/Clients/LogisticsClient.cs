using System;
using Design.Patterns.Creational.FactoryMethod.Factories;
using Design.Patterns.Creational.FactoryMethod.Interfaces;

namespace Design.Patterns.Creational.FactoryMethod.Clients
{
    public class LogisticsClient
    {
        public void Main()
        {
            Console.WriteLine($"Set delivery plans: {new RoadLogistics().DeliveryPlan(DateTime.Today, DateTime.Today.AddDays(5))} with sea logistics.");
            PrepareTransport(new SeaLogistics());

            Console.WriteLine($"Set delivery plans: {new RoadLogistics().DeliveryPlan(DateTime.Today, DateTime.Today.AddDays(5))} with road logistics.");
            PrepareTransport(new RoadLogistics());
        }

        private protected void PrepareTransport(ILogistics logistics)
        {
            Console.WriteLine("Preparing goods to deliver");
            logistics.CreateTransport().Deliver();
        }
    }
}
