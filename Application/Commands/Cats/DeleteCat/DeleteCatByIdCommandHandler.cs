using Domain.Models;
using Infrastructure.Repositories.Animal.Cats;
using MediatR;

namespace Application.Commands.Cats.DeleteCat
{
    public class DeleteCatByIdCommandHandler : IRequestHandler<DeleteCatByIdCommand, Cat>
    {
        private readonly ICatRepository _catRepository;

        public DeleteCatByIdCommandHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository ?? throw new ArgumentNullException(nameof(catRepository));
        }
        public async Task<Cat> Handle(DeleteCatByIdCommand request, CancellationToken cancellationToken)
        {
            var catToDelete = await _catRepository!.GetCatByIdAsync(request.Id);
            if (catToDelete != null)
            {
                await _catRepository!.DeleteCatByIdAsync(request.Id);
                return catToDelete;
            }
            return null!;
        }
    }
}