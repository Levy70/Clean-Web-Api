using Domain.Models;
using Infrastructure.Repositories.Animal.Birds;
using MediatR;

namespace Application.Commands.Birds.UpdateBird
{
    public class UpdateBirdByIdCommandHandler : IRequestHandler<UpdateBirdByIdCommand, Bird>
    {
        private readonly IBirdRepository? _birdRepository;

        public UpdateBirdByIdCommandHandler(IBirdRepository birdRepository)
        {
            _birdRepository = birdRepository ?? throw new ArgumentNullException(nameof(birdRepository));
        }
        public async Task<Bird> Handle(UpdateBirdByIdCommand request, CancellationToken cancellationToken)
        {
            var birdToUpdate = await _birdRepository!.GetBirdByIdAsync(request.Id);
            if (birdToUpdate != null)
            {
                await _birdRepository!.UpdateBirdByIdAsync(request.Id);
                return birdToUpdate;
            }
            return null!;
        }
    }

}