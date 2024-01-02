using Domain.Models;
using Infrastructure.Repositories.Animal.Birds;
using MediatR;

namespace Application.Commands.Birds.DeleteBird
{
    public class DeleteBirdByIdCommandHandler : IRequestHandler<DeleteBirdByIdCommand, Bird>
    {
        private readonly IBirdRepository? _birdRepository;

        public DeleteBirdByIdCommandHandler(IBirdRepository birdRepository)
        {
            _birdRepository = birdRepository ?? throw new ArgumentNullException(nameof(birdRepository));
        }
        public async Task<Bird> Handle(DeleteBirdByIdCommand request, CancellationToken cancellationToken)
        {
            var birdToDelete = await _birdRepository!.GetBirdByIdAsync(request.Id);
            if (birdToDelete != null)
            {
                await _birdRepository!.DeleteBirdByIdAsync(request.Id);
                return birdToDelete;
            }
            return null!;

        }
    }
}