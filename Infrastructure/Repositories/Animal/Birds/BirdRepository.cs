using Domain.Models;
using Infrastructure.Database.MySQLDatabase;
using Infrastructure.Repositories.Animal.Birds;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Repositories.BirdRepository
{
    public class BirdRepository : IBirdRepository
    {
        private readonly MySqlDatabase _context;
        public BirdRepository(MySqlDatabase context)
        {
            _context = context;
        }
        public async Task<List<Bird>> GetAllBirdsAsync()
        {
            return await _context.Birds.ToListAsync();
        }
        public async Task<Bird?> GetBirdByIdAsync(Guid id)
        {
            return await _context.Birds.FirstOrDefaultAsync(bird => bird.Id == id);
        }
        public async Task<Bird?> CreateBirdAsync(Bird bird)
        {
            _context.Birds.Add(bird);
            await _context.SaveChangesAsync();
            return bird;
        }
        public async Task<Bird?> UpdateBirdByIdAsync(Guid id)
        {
            Bird? birdToUpdate = await _context.Birds.FirstOrDefaultAsync(bird => bird.Id == id);
            if (birdToUpdate != null)
            {
                _context.Birds.Update(birdToUpdate);
                await _context.SaveChangesAsync();
                return birdToUpdate;
            }
            return null;
        }
        public async Task<Bird?> DeleteBirdByIdAsync(Guid id)
        {
            Bird? birdToDelete = await _context.Birds.FirstOrDefaultAsync(bird => bird.Id == id);
            if (birdToDelete != null)
            {
                _context.Birds.Remove(birdToDelete);
                await _context.SaveChangesAsync();
                return birdToDelete;
            }
            return null;
        }
        public async Task<Bird?> GetBirdsByColor(Bird bird)
        {
            return await _context.Birds.FirstOrDefaultAsync(bird => bird.Color == bird.Color);
        }
        public ICollection<Bird> Birds { get; private set; }
    }
}