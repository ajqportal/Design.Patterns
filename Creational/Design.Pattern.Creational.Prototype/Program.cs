using System;
using Design.Patterns.Creational.Prototype.Businesses;
using Design.Patterns.Creational.Prototype.Models;

namespace Design.Patterns.Creational.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 27;
            person.BirthDate = Convert.ToDateTime("1992-08-03");
            person.Name = "Alvin Quezon";
            person.IdInfo = new IdInfo(777);

            // Perform a shallow copy of p1 and assign it to p2.
            Person person2 = person.ShallowCopy();

            // Make a deep copy of p1 and assign it to p3.
            Person person3 = person.DeepCopy();

            // Display values of p1, p2 and p3.
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("Person1 instance values: ");
            DisplayValues(person);
            Console.WriteLine("Person2 instance values:");
            DisplayValues(person2);
            Console.WriteLine("Person3 instance values:");
            DisplayValues(person3);

            // Change the value of p1 properties and display the values of p1,
            // p2 and p3.
            person.Age = 29;
            person.BirthDate = Convert.ToDateTime("1990-11-10");
            person.Name = "Irish Desiree Singson Serida";
            person.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("Person1 instance values:");
            DisplayValues(person);
            Console.WriteLine("Person2 instance values (reference values have changed):");
            DisplayValues(person2);
            Console.WriteLine("Person3 instance values (everything was kept the same):");
            DisplayValues(person3);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}, BirthDate: {p.BirthDate.ToString("d")}");
            Console.WriteLine($"Id: {p.IdInfo.IdNumber}");
        }
    }
}
