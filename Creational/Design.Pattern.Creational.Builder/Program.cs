using System;
using Design.Pattern.Creational.Builder.Builders;
using Design.Pattern.Creational.Builder.Directors;

namespace Design.Pattern.Creational.Builder
{
    class Program
    {

        static void Main(string[] args)
        {
            // create instance
            var director = new HouseBuilderDirector();
            var modernHouseBuilder = new ModernHouseBuilder();
            director.Builder = modernHouseBuilder;       


            Console.WriteLine("Building Modern House");
            director.BuildHouse();

            modernHouseBuilder.GetModernHouse().Wall.BuildWall();
            modernHouseBuilder.GetModernHouse().Door.BuildDoor();
            modernHouseBuilder.GetModernHouse().Floor.BuildFloor();
            modernHouseBuilder.GetModernHouse().Roof.BuildRoof();
            modernHouseBuilder.GetModernHouse().Window.BuildWindow();
        }
    }
}
