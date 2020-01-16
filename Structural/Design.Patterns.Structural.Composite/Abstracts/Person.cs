using System;

namespace Design.Patterns.Structural.Composite.Abstracts
{
    public abstract class Person
    {
        public Person() { }

        public abstract string GetName();

        public virtual void SayHello(Person person) => Console.WriteLine($"Hello, my name is {person.GetName()}");

        public virtual void SayBye(Person person) => Console.WriteLine($"{person.GetName()} is signing off");

        public virtual bool IsComposite() => true;
    }
}
