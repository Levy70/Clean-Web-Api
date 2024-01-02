namespace Domain.Models;

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string? Password { get; set; }

    //property for many-to-many relationship
    public virtual ICollection<UserAnimal> UserAnimals { get; set; } = new List<UserAnimal>();
}