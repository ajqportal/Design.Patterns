using System;
using Design.Patterns.Creational.FactoryMethod.Interfaces;

namespace Design.Patterns.Creational.FactoryMethod.Models
{
    public class Ship : ITransport
    {
        private readonly string _cargoType;
        private readonly string _departure;
        private readonly string _arrival;
        private readonly int _weight;

        public Ship(string cargoType, string departure, string arrival, int weight)
        {
            _cargoType = cargoType;
            _departure = departure;
            _arrival = arrival;
            _weight = weight;
        }

        private protected string CargoDetails()
        {
            return $"\n\tCargo Type: {_cargoType}\n\tDeparture: {_departure}\n\tArrival: {_arrival}\n\tWeight: {_weight}\n\n";
        }

        public void Deliver()
        {
            Console.WriteLine($"Delivering goods through {nameof(Ship)} with following attributes: {CargoDetails()}");
        }
    }
}
