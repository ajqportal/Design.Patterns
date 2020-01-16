using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Creational.Builder.Models.Parts
{
    public class Floor
    {
        private readonly string _material;
        private readonly string _color;

        public Floor() { }

        public Floor(string material, string color)
        {
            _material = material;
            _color = color;
        }

        public void BuildFloor() => Console.WriteLine($"Building floor with {_material} and colored with {_color}.");
    }
}
