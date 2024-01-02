using Domain.Models.Animal;

namespace Domain.Models
{
    public class Cat : AnimalModel
    {
        public int Weight { get; set; }
        public string Breed { get; set; } = string.Empty;
        public bool LikesToPlay { get; set; }
    }
}