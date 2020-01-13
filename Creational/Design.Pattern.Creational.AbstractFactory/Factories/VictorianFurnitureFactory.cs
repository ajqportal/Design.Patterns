using Design.Pattern.Creational.AbstractFactory.Interfaces;
using Design.Pattern.Creational.AbstractFactory.Models.Chairs;
using Design.Pattern.Creational.AbstractFactory.Models.CoffeeTables;
using Design.Pattern.Creational.AbstractFactory.Models.Sofas;

namespace Design.Pattern.Creational.AbstractFactory.Factories
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair("Red Velvet", true, 4, "Sheep Wool");
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable("Wooden Brown", true, 4, "Adam Tree");
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa(8, "Maroon", true, 4, "Crocodile Leather");
        }
    }
}
