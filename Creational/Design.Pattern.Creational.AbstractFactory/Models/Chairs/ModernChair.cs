using Design.Pattern.Creational.AbstractFactory.Interfaces;

namespace Design.Pattern.Creational.AbstractFactory.Models.Chairs
{
    public class ModernChair : IChair
    {
        private readonly string _color;
        private readonly bool _hasArms;
        private readonly int _numberOfLegs;
        private readonly string _typeOfCloth;

        public ModernChair(string color, bool hasArms, int numberOfLegs, string typeOfMaterial)
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
