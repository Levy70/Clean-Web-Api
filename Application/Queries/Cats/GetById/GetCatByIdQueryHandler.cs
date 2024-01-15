using Domain.Models;
using Infrastructure.Repositories.Animal.Cats;
using MediatR;

namespace Application.Queries.Cats.GetById
{
    public class GetCatByIdQueryHandler : IRequestHandler<GetCatByIdQuery, Cat>
    {
        private readonly ICatRepository _catRepository;

        public GetCatByIdQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }
        public async Task<Cat> Handle(GetCatByIdQuery request, CancellationToken cancellationToken)
        {
            Cat? wantedCat = await _catRepository.GetCatByIdAsync(request.Id);

            if (wantedCat == null)
            {
                throw new KeyNotFoundException($"No cat found with the id {request.Id}");
            }
            return wantedCat;
        }
    }
}
