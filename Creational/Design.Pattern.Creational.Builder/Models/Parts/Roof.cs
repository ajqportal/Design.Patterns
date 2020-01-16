using System;

namespace Design.Patterns.Creational.Builder.Models.Parts
{
    public class Roof
    {
        private readonly string _material;
        private readonly bool _hasChimney;
        public Roof() { }

        public Roof(string material, bool hasChimney)
        {
            _material = material;
            _hasChimney = hasChimney;
        }

        public void BuildRoof() => Console.WriteLine(_hasChimney == false ? $"Building roof with {_material}" : $"Building roof with {_material} and has Chimney");
    }
}
