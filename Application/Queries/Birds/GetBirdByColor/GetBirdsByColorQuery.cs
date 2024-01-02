using Domain.Models;
using MediatR;

namespace Application.Queries.Birds.GetByColor
{
    public class GetBirdsByColorQuery : IRequest<List<Bird>>
    {
        public GetBirdsByColorQuery(string color)
        {
            Color = color;
        }
        public string Color { get; }
    }
}