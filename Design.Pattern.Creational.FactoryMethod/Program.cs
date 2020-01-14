using System;
using Design.Pattern.Creational.FactoryMethod.Clients;

namespace Design.Pattern.Creational.FactoryMethod
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
