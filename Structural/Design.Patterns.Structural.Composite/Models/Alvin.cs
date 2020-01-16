using Design.Patterns.Structural.Composite.Abstracts;

namespace Design.Patterns.Structural.Composite.Models
{
    public class Alvin: Person
    {
        public override string GetName() => "Alvin";
        public override bool IsComposite() => false;
    }
}
