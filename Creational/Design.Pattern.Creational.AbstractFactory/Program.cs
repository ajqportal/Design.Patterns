using Design.Pattern.Creational.AbstractFactory.Clients;
using System;

namespace Design.Patterns.Abstract.Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            new CreateFurniture().CreateFurnitures();
            Console.ReadKey();
        }
    }
}
