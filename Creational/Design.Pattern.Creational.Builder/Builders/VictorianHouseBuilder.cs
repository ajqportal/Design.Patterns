using Design.Pattern.Creational.Builder.Interfaces;
using Design.Pattern.Creational.Builder.Models;
using Design.Pattern.Creational.Builder.Models.Parts;

namespace Design.Pattern.Creational.Builder.Builders
{
    public class VictorianHouseBuilder : IHouseBuilder
    {
        private VictorianHouse _victorianHouse;

        public VictorianHouseBuilder()
        {
            _victorianHouse = new VictorianHouse();
        }

        public void Reset()
        {
            _victorianHouse = new VictorianHouse();
        }

        public void BuildWalls(int numberOfWalls, string material)
        {
            _victorianHouse.Wall = new Wall(numberOfWalls, material);
        }

        public void BuildRoof(string material, bool hasChimney)
        {
            _victorianHouse.Roof = new Roof(material, hasChimney);
        }

        public void BuildWindows(int numberOfWindows, string material)
        {
            _victorianHouse.Window = new Window(numberOfWindows, material);
        }

        public void BuildDoors(int numberOfDoors, string material)
        {
            _victorianHouse.Door = new Door(numberOfDoors, material);
        }

        public void BuildFloors(string material, string color)
        {
            _victorianHouse.Floor = new Floor(material, color);
        }

        public VictorianHouse GetVictorianHouse()
        {
            return _victorianHouse;
        }
    }
}
