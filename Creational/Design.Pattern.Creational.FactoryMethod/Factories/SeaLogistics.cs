using System;
using Design.Pattern.Creational.FactoryMethod.Interfaces;
using Design.Pattern.Creational.FactoryMethod.Models;

namespace Design.Pattern.Creational.FactoryMethod.Factories
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
