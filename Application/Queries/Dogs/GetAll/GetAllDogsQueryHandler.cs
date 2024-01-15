using Domain.Models;
using Infrastructure.Repositories.Animal.Dogs;
using MediatR;


namespace Application.Queries.Dogs.GetAll
{
    public class GetAllDogsQueryHandler : IRequestHandler<GetAllDogsQuery, List<Dog>>
    {
        private readonly IDogRepository _dogRepository;

        public GetAllDogsQueryHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }

        public async Task<List<Dog>> Handle(GetAllDogsQuery request, CancellationToken cancellationToken)
        {
            List<Dog> allDogsFromMySqlDatabase = await _dogRepository.GetAllDogsAsync();
            return allDogsFromMySqlDatabase;
        }
    }
}
