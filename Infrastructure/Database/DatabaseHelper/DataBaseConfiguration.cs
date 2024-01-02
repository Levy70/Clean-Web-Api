using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infrastructure.Database.DatabaseHelpers
{
    public class DataBaseConfiguration : IDatabaseConfiguration
    {
        public void Configure(DbContextOptionsBuilder optionBuilder, string connectionString)
        {

            optionBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 35))).AddInterceptors(new CommandLoggingInterceptor());
            throw new NotImplementedException();
        }
    }
}