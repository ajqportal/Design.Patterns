using Design.Pattern.Creational.Builder.Interfaces;

namespace Design.Pattern.Creational.Builder.Directors
{
    public class HouseBuilderDirector
    {
        private IHouseBuilder _builder;

        public IHouseBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildHouse()
        {
            _builder.Reset();
            _builder.BuildDoors(2, "Steel Doors");
            _builder.BuildWalls(4, "Steel Walls");
            _builder.BuildFloors("Marble", "Maroon");
            _builder.BuildRoof("Solar Panel Roof", false);
            _builder.BuildWindows(3, "Steel Windows");
        }
    }
}
