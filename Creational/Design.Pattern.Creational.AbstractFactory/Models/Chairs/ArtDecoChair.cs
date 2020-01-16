using Design.Patterns.Creational.AbstractFactory.Interfaces;

namespace Design.Patterns.Creational.AbstractFactory.Models.Chairs
{
    public class ArtDecoChair : IChair
    {
        private readonly string _color;
        private readonly bool _hasArms;
        private readonly int _numberOfLegs;
        private readonly string _typeOfCloth;

        public ArtDecoChair(string color, bool hasArms, int numberOfLegs, string typeOfMaterial)
        {
            _color = color;
            _hasArms = hasArms;
            _numberOfLegs = numberOfLegs;
            _typeOfCloth = typeOfMaterial;
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
            return _typeOfCloth;
        }
    }
}
