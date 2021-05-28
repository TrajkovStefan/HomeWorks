namespace SEDC.Task1.Domain.Domain
{
    public class Dog : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public override string GetInfo()
        {
            return $"The dog {Name} has {Age} years old and is {Color}";
        }
    }
}