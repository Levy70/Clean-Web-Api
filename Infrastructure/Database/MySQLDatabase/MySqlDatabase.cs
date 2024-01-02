using Domain.Models;
using Domain.Models.Animal;
using Infrastructure.Database.DatabaseHelpers;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.MySQLDatabase
{
    public class MySqlDatabase : DbContext
    {
        public MySqlDatabase() { }
        public MySqlDatabase(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Dog> Dogs { get; set; }
        public virtual DbSet<Bird> Birds { get; set; }
        public virtual DbSet<Cat> Cats { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAnimal> UserAnimals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connectionString to Db
            string connectionString = "Server=localhost;Port=3306;Database=NewApi-Db;User=root;Password=Hardcore7045;";

            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 35)));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DataSeedHelper.SeedData(modelBuilder);

            //Set primary key for AnimalModel
            modelBuilder.Entity<AnimalModel>().HasKey(animal => animal.Id);

            //Configuration many-to-many relationship
            modelBuilder.Entity<UserAnimal>().HasKey(_userAnimal => new { _userAnimal.UserId, _userAnimal.AnimalId });

            modelBuilder.Entity<UserAnimal>()
                .HasOne(_userAnimal => _userAnimal.User)
                .WithMany(_user => _user.UserAnimals)
                .HasForeignKey(_userAnimal => _userAnimal.UserId);

            modelBuilder.Entity<UserAnimal>()
                .HasOne(_userAnimal => _userAnimal.Animal)
                .WithMany(_animal => _animal.UserAnimals)
                .HasForeignKey(_userAnimal => _userAnimal.AnimalId);

            //Configure Dog entity
            modelBuilder.Entity<Dog>()
                .Property(dog => dog.Name);
            modelBuilder.Entity<Dog>()
                .Property(dog => dog.Breed);
            modelBuilder.Entity<Dog>()
                .Property(dog => dog.Weight);

            //Configure Bird entity
            modelBuilder.Entity<Bird>()
                .Property(bird => bird.Name);
            modelBuilder.Entity<Bird>()
                .Property(bird => bird.Color);
            modelBuilder.Entity<Bird>()
                .Property(bird => bird.CanFly);

            //Configure Cat entity
            modelBuilder.Entity<Cat>()
                .Property(cat => cat.Name);
            modelBuilder.Entity<Cat>()
                .Property(cat => cat.LikesToPlay);
            modelBuilder.Entity<Cat>()
                .Property(cat => cat.Breed);
            modelBuilder.Entity<Cat>()
                .Property(cat => cat.Weight);
        }
    }
}
