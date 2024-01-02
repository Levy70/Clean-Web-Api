using Domain.Models;

namespace Infrastructure.Repositories.Users
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUser();
        Task<User> RegisterUser(User userToRegister);
    }
}