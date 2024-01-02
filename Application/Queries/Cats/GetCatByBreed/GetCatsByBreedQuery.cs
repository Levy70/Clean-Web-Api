using Domain.Models;
using MediatR;

namespace Application.Queries.Cats.GetCatsByBreed
{
    public class GetCatsByBreedQuery : IRequest<IEnumerable<Cat>>
    {
        public string Breed { get; set; } = string.Empty;

        public GetCatsByBreedQuery(string breed)
        {
            Breed = breed;
        }
    }
}