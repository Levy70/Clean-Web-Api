﻿using Domain.Models;
using Infrastructure.Repositories.Animal.Birds;
using MediatR;

namespace Application.Commands.Birds.AddBird
{
    public class AddBirdCommandHandler : IRequestHandler<AddBirdCommand, Bird>
    {
        private readonly IBirdRepository _birdRepository;

        public AddBirdCommandHandler(IBirdRepository birdRepository)
        {
            _birdRepository = birdRepository;
        }

        public async Task<Bird> Handle(AddBirdCommand request, CancellationToken cancellationToken)
        {
            Bird birdToCreate = new Bird
            {
                Id = Guid.NewGuid(),
                Name = request.NewBird.Name,
                CanFly = request.NewBird.CanFly,
                Color = request.NewBird.Color
            };
            await _birdRepository.CreateBirdAsync(birdToCreate);
            return birdToCreate;
        }
    }
}