using System;

namespace Design.Pattern.Creational.Builder.Models.Parts
{
    public class Wall
    {
        private readonly int _numberOfWalls;
        private readonly string _material;

        public Wall() { }

        public Wall(int numberOfWalls, string material)
        {
            _numberOfWalls = numberOfWalls;
            _material = material;
        }

        public void BuildWall() => Console.WriteLine($"Building {_numberOfWalls} wall(s) with {_material}.");
    }
}
