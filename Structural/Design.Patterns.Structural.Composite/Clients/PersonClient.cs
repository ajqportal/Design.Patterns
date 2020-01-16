using System;
using Design.Patterns.Structural.Composite.Abstracts;

namespace Design.Patterns.Structural.Composite.Clients
{
    public class PersonClient
    {
        public void GetPerson(Person person)
        {
            Console.WriteLine($"Here is now!\n\n{person.GetName()}");
        }

        public void GetAnotherPerson(Person person)
        {
            if (!person.IsComposite())
            {
                Console.WriteLine($"Hey you! how are you!\n\n{person.GetName()}");
            }
            Console.WriteLine($"Here we go again----\n\n\n{person.GetName()}");
            person.SayHello(person);
            person.SayBye(person);
        }
    }
}
