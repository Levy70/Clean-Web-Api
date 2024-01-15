using Domain.Models;
using Infrastructure.Repositories.Animal.Dogs;
using MediatR;

namespace Application.Queries.Dogs.GetById
{
    public class GetDogByIdQueryHandler : IRequestHandler<GetDogByIdQuery, Dog>
    {
        private readonly IDogRepository _dogRepository;

        public GetDogByIdQueryHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }
        public async Task<Dog> Handle(GetDogByIdQuery request, CancellationToken cancellationToken)
        {
            Dog? wantedDog = await _dogRepository.GetDogByIdAsync(request.Id);

            if (wantedDog == null)
            {
                throw new KeyNotFoundException($"No dog found with the id {request.Id}");
            }
            return wantedDog;
        }
    }
}