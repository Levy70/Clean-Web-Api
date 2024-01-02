using Domain.Models;
using Infrastructure.Database.MySQLDatabase;
using Infrastructure.Repositories.Users;

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
    }
}
