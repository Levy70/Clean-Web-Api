using Domain.Models.Animal;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class UserAnimal
    {
        public Guid UserId { get; set; }
        [Required]
        public virtual User? User { get; set; }

        public Guid AnimalId { get; set; }

        [Required]
        public AnimalModel? Animal { get; set; }
    }
}