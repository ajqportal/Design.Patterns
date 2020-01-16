using System;
using Design.Patterns.Creational.FactoryMethod.Clients;

namespace Design.Patterns.Creational.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            new LogisticsClient().Main();
            Console.ReadKey();
        }
    }
}
