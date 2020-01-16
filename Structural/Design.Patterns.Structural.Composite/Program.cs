using System;
using Design.Patterns.Structural.Composite.Clients;
using Design.Patterns.Structural.Composite.Models;

namespace Design.Patterns.Structural.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var personClient = new PersonClient();

            var alvin = new Alvin();
            Console.WriteLine("I get your name please?\n");
            personClient.GetPerson(alvin);

            var irish = new CompositeMe();
            Console.WriteLine("Hey there new girl!\n");
            personClient.GetAnotherPerson(irish);
        }
    }
}
