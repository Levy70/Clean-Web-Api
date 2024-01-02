using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.DatabaseHelpers
{
    public class DataSeedHelper
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            SeedDogs(modelBuilder);
            SeedCats(modelBuilder);
            SeedBirds(modelBuilder);
        }

        private static void SeedCats(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>().HasData(
                new Cat { Id = Guid.NewGuid(), Name = "Nuno" },
                new Cat { Id = Guid.NewGuid(), Name = "Mani" },
                new Cat { Id = Guid.NewGuid(), Name = "Puppy" },
                new Cat { Id = Guid.NewGuid(), Name = "Shima" }
                );
        }

        private static void SeedDogs(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dog>().HasData(
                new Dog { Id = Guid.NewGuid(), Name = "Sedel" },
                new Dog { Id = Guid.NewGuid(), Name = "Tommy" },
                new Dog { Id = Guid.NewGuid(), Name = "Misha" },
                new Dog { Id = Guid.NewGuid(), Name = "Tezar" }
                );
        }

        private static void SeedBirds(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bird>().HasData(
                new Bird { Id = Guid.NewGuid(), Name = "Parrot" },
                new Bird { Id = Guid.NewGuid(), Name = "Cortex" },
                new Bird { Id = Guid.NewGuid(), Name = "Fench" },
                new Bird { Id = Guid.NewGuid(), Name = "Feri" }
                );
        }
    }
}
