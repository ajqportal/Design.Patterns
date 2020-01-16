using Design.Patterns.Creational.Builder.Interfaces;
using Design.Patterns.Creational.Builder.Models;
using Design.Patterns.Creational.Builder.Models.Parts;

namespace Design.Patterns.Creational.Builder.Builders
{
    public class ModernHouseBuilder : IHouseBuilder
    {
        private ModernHouse _modernHouse;

        public ModernHouseBuilder()
        {
            _modernHouse = new ModernHouse();
        }

        public void Reset()
        {
           _modernHouse = new ModernHouse();
        }

        public void BuildWalls(int numberOfWalls, string material)
        {
            _modernHouse.Wall = new Wall(numberOfWalls, material);
        }

        public void BuildRoof(string material, bool hasChimney)
        {
            _modernHouse.Roof = new Roof(material, hasChimney);
        }

        public void BuildWindows(int numberOfWindows, string material)
        {
            _modernHouse.Window = new Window(numberOfWindows, material);
        }

        public void BuildDoors(int numberOfDoors, string material)
        {
            _modernHouse.Door = new Door(numberOfDoors, material);
        }

        public void BuildFloors(string material, string color)
        {
            _modernHouse.Floor = new Floor(material, color);
        }

        public ModernHouse GetModernHouse()
        {
            return _modernHouse;
        }
    }
}
