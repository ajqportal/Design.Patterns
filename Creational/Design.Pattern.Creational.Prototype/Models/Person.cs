using System;
using Design.Pattern.Creational.Prototype.Businesses;

namespace Design.Pattern.Creational.Prototype.Models
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person) this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clonePerson = (Person) this.MemberwiseClone();
            clonePerson.IdInfo = new IdInfo(IdInfo.IdNumber);
            clonePerson.Name = new string(Name.ToCharArray());
            return clonePerson;
        }
    }
}
