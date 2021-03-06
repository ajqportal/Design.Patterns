﻿namespace Design.Patterns.Creational.AbstractFactory.Interfaces
{
    public interface IChair
    {
        int NumberOfLegs();
        bool HasArms();
        string Color();
        string TypeOfMaterial();
    }
}
