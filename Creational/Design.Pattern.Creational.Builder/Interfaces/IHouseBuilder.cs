namespace Design.Pattern.Creational.Builder.Interfaces
{
    public interface IHouseBuilder
    {
        void Reset();
        void BuildWalls(int numberOfWalls, string material);
        void BuildRoof(string material, bool hasChimney);
        void BuildWindows(int numberOfWindows, string material);
        void BuildDoors(int numberOfDoors, string material);
        void BuildFloors(string material, string color);
    }
}
