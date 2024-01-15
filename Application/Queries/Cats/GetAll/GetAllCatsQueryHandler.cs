using Domain.Models;
using Infrastructure.Repositories.Animal.Cats;
using MediatR;


namespace Application.Queries.Cats.GetAll
{
    public class GetAllCatsQueryHandler : IRequestHandler<GetAllCatsQuery, List<Cat>>
    {
        private readonly ICatRepository _catRepository;

        public GetAllCatsQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }

        public async Task<List<Cat>> Handle(GetAllCatsQuery request, CancellationToken cancellationToken)
        {
            List<Cat> allCatsFromMySqlDatabase = await _catRepository.GetAllCatsAsync();
            return allCatsFromMySqlDatabase;
        }
    }
}



