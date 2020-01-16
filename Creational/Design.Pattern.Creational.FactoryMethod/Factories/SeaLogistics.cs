using System;
using Design.Patterns.Creational.FactoryMethod.Interfaces;
using Design.Patterns.Creational.FactoryMethod.Models;

namespace Design.Patterns.Creational.FactoryMethod.Factories
{
    public class SeaLogistics: ILogistics
    {
        public string DeliveryPlan(DateTime from, DateTime to)
        {
            return $"Delivery starting from {from.ToString("d")} and expected to arrived in: {to.ToString("d")}";
        }

        public ITransport CreateTransport()
        {
            return new Ship("Metal Elements", "Japan", "New Zealand", 2000);
        }
    }
}
