using Infrastructure.Database.MySQLDatabase;
using Infrastructure.Database.Repositories.BirdRepository;
using Infrastructure.Database.Repositories;
using Infrastructure.Repositories.Animal.Birds;
using Infrastructure.Repositories.Animal.Cats;
using Infrastructure.Repositories.Animal.Dogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Database.Repositories.Cats;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<MySqlDatabase>();
            services.AddScoped<IDogRepository, DogRepository>();
            services.AddScoped<ICatRepository, CatRepository>();
            services.AddScoped<IBirdRepository, BirdRepository>();

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
