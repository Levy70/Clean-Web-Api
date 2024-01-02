using Domain.Models;
using MediatR;

namespace Application.Queries.Dogs.GetById
{
    public class GetDogByIdQuery : IRequest<Cat>
    {
        public GetDogByIdQuery(Guid dogId)
        {
            Id = dogId;
        }

        public Guid Id { get; }
    }
}
