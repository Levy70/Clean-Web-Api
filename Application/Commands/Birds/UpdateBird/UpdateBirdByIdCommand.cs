using Application.Dtos;
using Domain.Models;
using MediatR;

namespace Application.Commands.Birds.UpdateBird
{
    public class UpdateBirdByIdCommand : IRequest<Bird>
    {
        public UpdateBirdByIdCommand(Guid id, BirdDto updatedBird)
        {

            Id = id;
            BirdToUpdate = updatedBird;

        }

        public BirdDto BirdToUpdate { get; }
        public Guid Id { get; }
    }
}