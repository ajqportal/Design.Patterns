using System;
using Design.Patterns.Creational.Singleton.Businesses;

namespace Design.Patterns.Creational.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"{NoteWriter.Instance.SetTitle("Today is the big day!")}\n\n{NoteWriter.Instance.SetBody("It's my birthday and you are all guys invited to my party! Lets go!")}\n\n{NoteWriter.Instance.Author("Alvin Quezon")}");
        }
    }
}
