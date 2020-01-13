using Design.Pattern.Creational.AbstractFactory.Factories;
using Design.Pattern.Creational.AbstractFactory.Interfaces;
using System;

namespace Design.Pattern.Creational.AbstractFactory.Clients
{
    public class CreateFurniture
    {
        public void CreateFurnitures()
        {
            Console.WriteLine($"Starting building {nameof(VictorianFurnitureFactory).Replace("FurnitureFactory", "")} furniture.");
            BuildFurnitures(new VictorianFurnitureFactory());
            Console.WriteLine("Done building your furniture.");
        }

        private protected void BuildFurnitures(IFurnitureFactory furnitureFactory)
        {
            var chair = furnitureFactory.CreateChair();
            var coffeeTable = furnitureFactory.CreateCoffeeTable();
            var sofa = furnitureFactory.CreateSofa();

            Console.WriteLine($"Building Chair with attributes:\n\tColor: {chair.Color()}\n\tHave Arms?: {chair.HasArms()}\n\tNumber of Legs: {chair.NumberOfLegs()}\n\tMaterial Used: {chair.TypeOfMaterial()}\n\n");
            Console.WriteLine($"Building Coffee Table with attributes:\n\tColor: {coffeeTable.Color()}\n\tHave Sliding Door?: {coffeeTable.HasSlidingDoor()}\n\tNumber of Legs: {coffeeTable.NumberOfLegs()}\n\tMaterial Used: {coffeeTable.TypeOfMaterial()}\n\n");
            Console.WriteLine($"Building Sofa with attributes:\n\tColor: {sofa.Color()}\n\tCapacity: {sofa.Capacity()}\n\tHave Arms?: {sofa.HasArms()}\n\tNumber Of Legs: {sofa.NumberOfLegs()}\n\tMaterial Used: {sofa.TypeOfMaterial()}\n\n");
        }
    }
}
