using System;
using System.Dynamic;

namespace Design.Pattern.Creational.Singleton.Businesses
{
    /// <summary>
    /// Thread safety singleton with Fully Lazy Type Instance!
    /// Highly recommended when implementing a singleton pattern.
    /// </summary>
    public sealed class NoteWriter
    {
        // empty constructor
        public NoteWriter() { } 

        // If you're using .NET 4 (or higher) and/or .NET Core then you can use the System.Lazy<T> type to make the laziness really simple.
        // All you need to do is pass a delegate to the constructor that calls the Singleton constructor, which is done most easily with a lambda expression.
        // It also allows you to check whether or not the instance has been created with the IsValueCreated property.
        private static readonly Lazy<NoteWriter> lazy = new Lazy<NoteWriter>(() => new NoteWriter());

        public static NoteWriter Instance => lazy.Value;

        public string SetTitle(string title)
        {
            return $"Title: {title}";
        }

        public string SetBody(string body)
        {
            return $"Body:\n{body}";
        }

        public string Author(string author)
        {
            return $"By: {author}";
        }
    }
}
