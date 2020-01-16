using Design.Patterns.Creational.AbstractFactory.Interfaces;
using Design.Patterns.Creational.AbstractFactory.Models.Chairs;
using Design.Patterns.Creational.AbstractFactory.Models.CoffeeTables;
using Design.Patterns.Creational.AbstractFactory.Models.Sofas;

namespace Design.Patterns.Creational.AbstractFactory.Factories
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair("Transparent", false, 1, "Plastic Glass");
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable("Sky Blue", true, 2, "Plastic");
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa(3, "Transparent", false, 1, "Plastic Glass");
        }
    }
}
