using Application.Queries.Dogs.GetAll;
using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Dogs
{
    internal sealed class GetAllDogsQueryHandler : IRequestHandler<GetAllDogsQuery, List<Cat>>
    {
        private readonly MockDatabase _mockDatabase;

        public GetAllDogsQueryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }
        public Task<List<Cat>> Handle(GetAllDogsQuery request, CancellationToken cancellationToken)
        {
            List<Cat> allDogsFromMockDatabase = _mockDatabase.Dogs;
            return Task.FromResult(allDogsFromMockDatabase);
        }
    }
}
