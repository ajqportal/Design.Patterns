using System;

namespace Design.Patterns.Creational.Builder.Models.Parts
{
    public class Window
    {
        private readonly int _numberOfWindow;
        private readonly string _material;

        public Window() { }

        public Window(int numberOfWindow, string material)
        {
            _numberOfWindow = numberOfWindow;
            _material = material;
        }

        public void BuildWindow() => Console.WriteLine($"Building {_numberOfWindow} window(s) with {_material} material.");
    }
}
