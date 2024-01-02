namespace Domain.Models.Animal
{
    public class AnimalModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        //Create property for many-to-many relationship
        public virtual ICollection<UserAnimal> UserAnimals { get; set; } = new List<UserAnimal>();
    }
}
