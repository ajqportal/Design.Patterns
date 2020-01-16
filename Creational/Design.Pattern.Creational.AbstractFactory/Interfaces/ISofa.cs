namespace Design.Patterns.Creational.AbstractFactory.Interfaces
{
    public interface ISofa
    {
        int NumberOfLegs();
        int Capacity();
        bool HasArms();
        string Color();
        string TypeOfMaterial();
    }
}
