using Infrastructure.Database.MySQLDatabase;
using Infrastructure.Database.Repositories.BirdRepository;
using Infrastructure.Database.Repositories;
using Infrastructure.Repositories.Animal.Birds;
using Infrastructure.Repositories.Animal.Cats;
using Infrastructure.Repositories.Animal.Dogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Database.Repositories.Cats;
using Infrastructure.Repositories.Users;
using Infrastructure.Repositories.Authorization;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IDogRepository, DogRepository>();
            services.AddTransient<ICatRepository, CatRepository>();
            services.AddTransient<IBirdRepository, BirdRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IAuthRepository, AuthRepository>();

            services.AddDbContext<MySqlDatabase>(options =>
            {
                //connectionString to Db
                string connectionString = "Server=localhost;Port=3306;Database=NewApi-Db;User=root;Password=Hardcore7045;";

                options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 35)));
            });
            return services;
        }
    }
}
