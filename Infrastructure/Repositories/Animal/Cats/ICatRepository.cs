using Domain.Models;

namespace Infrastructure.Repositories.Animal.Cats
{
    public interface ICatRepository
    {
        Task<List<Cat>> GetAllDogs();
        Task<List<Cat>> GetAllCatsAsync();
        Task<Cat?> GetCatByIdAsync(Guid id);
        Task<Cat?> CreateCatAsync(Cat cat);
        Task<Cat?> UpdateCatByIdAsync(Guid id);
        Task<Cat?> DeleteCatByIdAsync(Guid id);
        Task<List<Cat>> GetCatsByBreedAsync(string breed);
        Task<List<Cat>> GetCatsByWeightAsync(int weight);
        Task<Cat> GetCatById(Guid id);
    }
}
