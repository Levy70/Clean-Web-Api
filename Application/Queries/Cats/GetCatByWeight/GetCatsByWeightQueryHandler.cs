using Domain.Models;
using Infrastructure.Repositories.Animal.Cats;
using MediatR;

namespace Application.Queries.Cats.GetCatsByWeight
{
    public class GetCatsByWeightQueryHandler : IRequestHandler<GetCatsByWeightQuery, IEnumerable<Cat>>
    {
        private readonly ICatRepository _catRepository;
        public GetCatsByWeightQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }
        public async Task<IEnumerable<Cat>> Handle(GetCatsByWeightQuery request, CancellationToken cancellationToken)
        {
            var cats = await _catRepository.GetAllCatsAsync();
            return cats.Where(cat => cat.Weight == request.Weight);
        }
    }
}