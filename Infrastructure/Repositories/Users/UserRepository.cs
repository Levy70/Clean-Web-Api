using Domain.Models;
using Infrastructure.Database.MySQLDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog;

namespace Infrastructure.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly MySqlDatabase _mysqlDatabase;

        public UserRepository(MySqlDatabase mysqlDatabase)
        {
            _mysqlDatabase = mysqlDatabase;
        }

        public async Task<User> RegisterUser(User userToRegister)
        {
            try
            {
                _mysqlDatabase.Users.Add(userToRegister);
                _mysqlDatabase.SaveChanges();
                return await Task.FromResult(userToRegister);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public async Task<List<User>> GetAllUser()
        {
            try
            {
                List<User> allUsersFromDatabase = _mysqlDatabase.Users.ToList();
                return await Task.FromResult(allUsersFromDatabase);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public Task<bool> AddUserAnimalAsync(UserAnimal userAnimal)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAnimalByUser(Guid userId, Guid animalId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAnimal(Guid userId, Guid oldAnimalId, Guid newAnimalId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserAnimal>> GetAllUsersWithAnimals()
        {
            throw new NotImplementedException();
        }
    }
}
