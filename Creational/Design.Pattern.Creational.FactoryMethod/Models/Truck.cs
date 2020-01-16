using System;
using Design.Patterns.Creational.FactoryMethod.Interfaces;

namespace Design.Patterns.Creational.FactoryMethod.Models
{
    public class Truck: ITransport
    {
        private readonly string _cargoType;
        private readonly string _departure;
        private readonly string _arrival;
        private readonly int _weight;
        private readonly double _distance;

        public Truck(string cargoType, string departure, string arrival, int weight, double distance)
        {
            _cargoType = cargoType;
            _departure = departure;
            _arrival = arrival;
            _weight = weight;
            _distance = distance;
        }

        private protected string CargoDetails()
        {
            return $"\n\tCargo Type: {_cargoType}\n\tDeparture: {_departure}\n\tArrival: {_arrival}\n\tWeight: {_weight}\n\tDistance: {_distance}\n\t";
        }

        public void Deliver()
        {
            Console.WriteLine($"Delivering goods through {nameof(Ship)} with following attributes: {CargoDetails()}");
        }

    }
}
