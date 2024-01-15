using Domain.Models;
using Infrastructure.Repositories.Animal.Birds;
using MediatR;

namespace Application.Queries.Birds.GetById
{
    public class GetBirdByIdQueryHandler : IRequestHandler<GetBirdByIdQuery, Bird>
    {
        private readonly IBirdRepository _birdRepository;

        public GetBirdByIdQueryHandler(IBirdRepository birdRepository)
        {
            _birdRepository = birdRepository;
        }
        public async Task<Bird> Handle(GetBirdByIdQuery request, CancellationToken cancellationToken)
        {
            Bird? wantedBird = await _birdRepository.GetBirdByIdAsync(request.Id);
            if (wantedBird == null)
            {
                throw new KeyNotFoundException($"No bird found with the id {request.Id}");
            }
            return wantedBird;
        }
    }
}