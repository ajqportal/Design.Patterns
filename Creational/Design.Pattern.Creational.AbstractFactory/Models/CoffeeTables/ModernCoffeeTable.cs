using Design.Patterns.Creational.AbstractFactory.Interfaces;

namespace Design.Patterns.Creational.AbstractFactory.Models.CoffeeTables
{
    public class ModernCoffeeTable: ICoffeeTable
    {
        private readonly string _color;
        private readonly bool _hasSlidingDoor;
        private readonly int _numberOfLegs;
        private readonly string _typeOfMaterial;

        public ModernCoffeeTable(string color, bool hasSlidingDoor, int numberOfLegs, string typeOfMaterial)
        {
            _color = color;
            _hasSlidingDoor = hasSlidingDoor;
            _numberOfLegs = numberOfLegs;
            _typeOfMaterial = typeOfMaterial;
        }
        public string Color()
        {
            return _color;
        }

        public bool HasSlidingDoor()
        {
            return _hasSlidingDoor;
        }

        public int NumberOfLegs()
        {
            return _numberOfLegs;
        }

        public string TypeOfMaterial()
        {
            return _typeOfMaterial;
        }
    }
}
