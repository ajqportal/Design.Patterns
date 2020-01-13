namespace Design.Pattern.Creational.AbstractFactory.Interfaces
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ICoffeeTable CreateCoffeeTable();
        ISofa CreateSofa();
    }
}
