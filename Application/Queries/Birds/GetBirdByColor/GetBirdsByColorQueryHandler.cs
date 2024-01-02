using Domain.Models;
using Infrastructure.Repositories.Animal.Birds;
using MediatR;

namespace Application.Queries.Birds.GetByColor
{
    public sealed class GetBirdsByColorQueryHandler : IRequestHandler<GetBirdsByColorQuery, IEnumerable<Bird>>
    {
        private readonly IBirdRepository _birdRepository;

        public GetBirdsByColorQueryHandler(IBirdRepository birdRepository)
        {
            _birdRepository = birdRepository;
        }

        public async Task<IEnumerable<Bird>> Handle(GetBirdsByColorQuery request, CancellationToken cancellationToken)
        {
            var cats = await _birdRepository.GetAllBirdsAsync();
            return cats.Where(cat => cat.Color == request.Color);
        }
    }
}