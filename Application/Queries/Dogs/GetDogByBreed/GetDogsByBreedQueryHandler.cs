using Domain.Models;
using Infrastructure.Repositories.Animal.Dogs;
using MediatR;

namespace Application.Queries.Dogs.GetDogsByBreed
{
    public sealed class GetDogsByBreedQueryHandler : IRequestHandler<GetDogsByBreedQuery, IEnumerable<Dog>>
    {
        private readonly IDogRepository _dogRepository;
        public GetDogsByBreedQueryHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }
        public async Task<IEnumerable<Dog>> Handle(GetDogsByBreedQuery request, CancellationToken cancellationToken)
        {
            var dogs = await _dogRepository.GetAllDogsAsync();
            return dogs.Where(dog => dog.Breed == request.Breed);
        }
    }
}