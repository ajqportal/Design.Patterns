using System;
using Design.Patterns.Structural.Composite.Abstracts;

namespace Design.Patterns.Structural.Composite.Models
{
    public class CompositeMe: Person
    {
        public override string GetName() => "Irish Desiree Serida";

        public override void SayHello(Person person) => Console.WriteLine($"Hello! My name is: {GetName()}");
        public override void SayBye(Person person) => Console.WriteLine($"Hello! My name is: {GetName()} and I'm out of the world!");

    }
}
