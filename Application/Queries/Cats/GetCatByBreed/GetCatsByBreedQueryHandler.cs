using Domain.Models;
using Infrastructure.Repositories.Animal.Cats;
using MediatR;

namespace Application.Queries.Cats.GetCatsByBreed
{
    public sealed class GetCatsByBreedQueryHandler : IRequestHandler<GetCatsByBreedQuery, IEnumerable<Cat>>
    {
        private readonly ICatRepository _catRepository;
        public GetCatsByBreedQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }
        public async Task<IEnumerable<Cat>> Handle(GetCatsByBreedQuery request, CancellationToken cancellationToken)
        {
            var cats = await _catRepository.GetAllCatsAsync();
            return cats.Where(cat => cat.Breed == request.Breed);
        }
    }
}