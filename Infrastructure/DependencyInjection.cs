using Infrastructure.Database.MySQLDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<MySqlDatabase>();
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
