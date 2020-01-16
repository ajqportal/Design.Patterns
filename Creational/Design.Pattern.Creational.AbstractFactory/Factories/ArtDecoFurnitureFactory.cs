using Design.Patterns.Creational.AbstractFactory.Interfaces;
using Design.Patterns.Creational.AbstractFactory.Models.Chairs;
using Design.Patterns.Creational.AbstractFactory.Models.CoffeeTables;
using Design.Patterns.Creational.AbstractFactory.Models.Sofas;

namespace Design.Patterns.Creational.AbstractFactory.Factories
{
    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ArtDecoChair("Wood Brown", true, 4, "Pollyester");
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable("Green Nature", false, 4, "Wooden Glass");
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa(6, "Red Marble", true, 4, "Nylon");
        }
    }
}
