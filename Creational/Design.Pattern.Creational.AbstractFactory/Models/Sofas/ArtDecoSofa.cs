using Design.Pattern.Creational.AbstractFactory.Interfaces;

namespace Design.Pattern.Creational.AbstractFactory.Models.Sofas
{
    public class ArtDecoSofa : ISofa
    {
        private readonly int _capacity;
        private readonly string _color;
        private readonly bool _hasArms;
        private readonly int _numberOfLegs;
        private readonly string _typeOfMaterial;

        public ArtDecoSofa(int capacity, string color, bool hasArms, int numberOfLegs, string typeOfMaterial)
        {
            _capacity = capacity;
            _color = color;
            _hasArms = hasArms;
            _numberOfLegs = numberOfLegs;
            _typeOfMaterial = typeOfMaterial;
        }

        public int Capacity()
        {
            return _capacity;
        }

        public string Color()
        {
            return _color;
        }

        public bool HasArms()
        {
            return _hasArms;
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
