using Design.Pattern.Creational.Builder.Models.Parts;

namespace Design.Pattern.Creational.Builder.Models
{
    public class ModernHouse
    {
        public Door Door { get; set; }
        public Window Window { get; set; }
        public Floor Floor { get; set; }
        public Roof Roof { get; set; }
        public Wall Wall { get; set; }
    }
}
