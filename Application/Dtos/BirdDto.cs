using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public class BirdDto
    {

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public bool CanFly { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; } = string.Empty;
    }
}
