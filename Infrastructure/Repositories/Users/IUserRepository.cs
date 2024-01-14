using Domain.Models;

namespace Infrastructure.Repositories.Users
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUser();
        Task<User> RegisterUser(User userToRegister);
        Task<bool> AddUserAnimalAsync(UserAnimal userAnimal);
        Task DeleteAnimalByUser(Guid userId, Guid animalId);
        Task UpdateUserAnimal(Guid userId, Guid oldAnimalId, Guid newAnimalId);
        Task<List<UserAnimal>> GetAllUsersWithAnimals();
    }
}