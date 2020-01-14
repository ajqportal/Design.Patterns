using System;
using Design.Pattern.Creational.FactoryMethod.Factories;
using Design.Pattern.Creational.FactoryMethod.Interfaces;

namespace Design.Pattern.Creational.FactoryMethod.Clients
{
    public class LogisticsClient
    {
        public void Main()
        {
            Console.WriteLine($"Set delivery plans: {new RoadLogistics().DeliveryPlan(DateTime.Today, DateTime.Today.AddDays(5))} with sea logistics.");
            PrepareTransport(new SeaLogistics());
        }

        private protected void PrepareTransport(ILogistics logistics)
        {
            Console.WriteLine($"Preparing goods to deliver");
            logistics.CreateTransport().Deliver();
        }
    }
}
