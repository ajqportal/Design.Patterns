using System;
using Design.Patterns.Creational.FactoryMethod.Interfaces;
using Design.Patterns.Creational.FactoryMethod.Models;

namespace Design.Patterns.Creational.FactoryMethod.Factories
{
    public class RoadLogistics : ILogistics
    {
        public string DeliveryPlan(DateTime from, DateTime to)
        {
            return $"Delivery starting from {from.ToString("d")} and expected to arrived in: {to.ToString("d")}";
        }

        public ITransport CreateTransport()
        {
            return new Truck("Perishable Goods", "Manila", "Cebu", 156, 1024);
        }
    }
}
