using System;
using Design.Pattern.Creational.FactoryMethod.Interfaces;
using Design.Pattern.Creational.FactoryMethod.Models;

namespace Design.Pattern.Creational.FactoryMethod.Factories
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
