using System;

namespace Design.Pattern.Creational.Builder.Models.Parts
{
    public class Door
    {
        private readonly int _numberOfDoors;
        private readonly string _material;

        public Door() { }

        public Door(int numberOfDoors, string material)
        {
            _numberOfDoors = numberOfDoors;
            _material = material;
        }

        public void BuildDoor() => Console.WriteLine($"Building {_numberOfDoors} door(s) with {_material} material.");
    }
}
