using Application.Dtos;
using Domain.Models;
using MediatR;

namespace Application.Commands.Dogs
{
    public class AddDogCommand : IRequest<Cat>
    {
        public AddDogCommand(DogDto newDog)
        {
            NewDog = newDog;
        }

        public DogDto NewDog { get; }
    }
}
