using Domain.Models;
using MediatR;

namespace Application.Queries.Dogs.GetDogsByWeight
{
    public class GetDogsByWeightQuery : IRequest<IEnumerable<Dog>>
    {
        public int Weight { get; set; }
        public GetDogsByWeightQuery(int weight)
        {
            Weight = weight;
        }
    }
}