using Domain.Models;
using MediatR;


namespace Application.Commands.Dogs.DeleteDog
{
    public class DeleteDogCommand : IRequest<Cat>
    {
        public DeleteDogCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}