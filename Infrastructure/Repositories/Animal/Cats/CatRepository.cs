using Domain.Models;
using Infrastructure.Database.MySQLDatabase;
using Infrastructure.Repositories.Animal.Cats;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Repositories.Cats
{
    public class CatRepository : ICatRepository
    {
        private readonly MySqlDatabase _context;
        public CatRepository(MySqlDatabase context)
        {
            _context = context;
        }
        public async Task<List<Cat>> GetAllCatsAsync()
        {
            return await _context.Cats.ToListAsync();
        }
        public async Task<Cat?> GetCatByIdAsync(Guid id)
        {
            return await _context.Cats.FirstOrDefaultAsync(cat => cat.Id == id);
        }
        public async Task<Cat?> CreateCatAsync(Cat cat)
        {
            _context.Cats.Add(cat);
            await _context.SaveChangesAsync();
            return cat;
        }
        public async Task<Cat?> UpdateCatByIdAsync(Guid id)
        {
            var cat = await _context.Cats.FirstOrDefaultAsync(cat => cat.Id == id);
            if (cat == null)
            {
                return null;
            }
            _context.Cats.Update(cat);
            await _context.SaveChangesAsync();
            return cat;
        }
        public async Task<Cat?> DeleteCatByIdAsync(Guid id)
        {
            var cat = await _context.Cats.FirstOrDefaultAsync(cat => cat.Id == id);
            if (cat == null)
            {
                return null;
            }
            _context.Cats.Remove(cat);
            await _context.SaveChangesAsync();
            return cat;
        }
        public async Task<List<Cat>> GetCatsByBreedAsync(string breed)
        {
            return await _context.Cats.Where(cat => cat.Breed == breed).ToListAsync();
        }
        public async Task<List<Cat>> GetCatsByWeightAsync(int weight)
        {
            return await _context.Cats.Where(cat => cat.Weight == weight).ToListAsync();
        }
    }
}
