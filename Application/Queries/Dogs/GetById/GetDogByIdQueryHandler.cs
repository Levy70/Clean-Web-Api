using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Dogs.GetById
{
    public class GetDogByIdQueryHandler : IRequestHandler<GetDogByIdQuery, Cat>
    {
        private readonly MockDatabase _mockDatabase;

        public GetDogByIdQueryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        public Task<Cat> Handle(GetDogByIdQuery request, CancellationToken cancellationToken)
        {
            Cat wantedDog = _mockDatabase.Dogs.FirstOrDefault(dog => dog.Id == request.Id)!;
            return Task.FromResult(wantedDog);
        }
    }
}
