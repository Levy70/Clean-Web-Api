using Domain.Models;
using Infrastructure.Repositories.Animal.Cats;
using MediatR;

namespace Application.Commands.Cats.AddCat
{
    public sealed class AddCatCommandHandler : IRequestHandler<AddCatCommand, Cat>
    {
        private readonly ICatRepository _catRepository;

        public AddCatCommandHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }


        public async Task<Cat> Handle(AddCatCommand request, CancellationToken cancellationToken)
        {
            Cat catToCreate = new()
            {
                Id = Guid.NewGuid(),
                Name = request.NewCat.Name,
                LikesToPlay = request.NewCat.LikesToPlay,
                Breed = request.NewCat.Breed,
                Weight = request.NewCat.Weight
            };

            await _catRepository.CreateCatAsync(catToCreate);

            return catToCreate;
        }
    }
}
