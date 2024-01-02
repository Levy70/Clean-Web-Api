using Domain.Models.Animal;

namespace Domain.Models
{
    public class Dog : AnimalModel
    {
        public int Weight { get; set; }
        public string Breed { get; set; } = string.Empty;
        public static string Bark()
        {
            return "This animal barks";
        }
    }
}
