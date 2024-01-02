using Domain.Models;
using Infrastructure.Repositories.Animal.Dogs;
using MediatR;

namespace Application.Commands.Dogs.DeleteDog
{
    public class DeleteDogByIdCommandHandler : IRequestHandler<DeleteDogByIdCommand, Dog>
    {
        private readonly IDogRepository _dogRepository;

        public DeleteDogByIdCommandHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository ?? throw new ArgumentNullException(nameof(dogRepository));
        }

        public async Task<Dog> Handle(DeleteDogByIdCommand request, CancellationToken cancellationToken)
        {
            var dogToDelete = await _dogRepository.GetDogByIdAsync(request.Id);
            if (dogToDelete != null)
            {
                await _dogRepository.DeleteDogByIdAsync(request.Id);
                return dogToDelete;
            }
            return null!;

        }
    }
}
