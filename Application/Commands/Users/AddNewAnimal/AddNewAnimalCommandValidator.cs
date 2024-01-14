using Application.Dtos;
using FluentValidation;

namespace Application.Commands.Users
{
    public class AddNewAnimalCommandValidator : AbstractValidator<AddAnimalToUserDto>
    {
        public AddNewAnimalCommandValidator()
        {
            RuleFor(dto => dto.UserId).NotEmpty().WithMessage("UserId får inte vara tom.");
            RuleFor(dto => dto.AnimalId).NotEmpty().WithMessage("AnimalId får inte vara tom.");
        }
    }
}
