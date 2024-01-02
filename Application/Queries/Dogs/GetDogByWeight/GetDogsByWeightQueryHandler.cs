using Domain.Models;
using Infrastructure.Repositories.Animal.Dogs;
using MediatR;

namespace Application.Queries.Dogs.GetDogsByWeight
{
    public class GetDogsByWeightQueryHandler : IRequestHandler<GetDogsByWeightQuery, IEnumerable<Dog>>
    {
        private readonly IDogRepository _dogRepository;
        public GetDogsByWeightQueryHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }
        public async Task<IEnumerable<Dog>> Handle(GetDogsByWeightQuery request, CancellationToken cancellationToken)
        {
            var dogs = await _dogRepository.GetAllDogsAsync();
            return dogs.Where(dog => dog.Weight == request.Weight);
        }
    }

}