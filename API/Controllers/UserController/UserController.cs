using Application.Commands.Users.Register;
using Application.Queries.Users.Login;
using Application.Dtos.Users;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Validators.User;
using Application.Dtos.Errors;
using Application.Exceptions.Authorize;
using Application.Commands.Users;
using Application.Dtos;
using Domain.Dtos;
using Application.Queries.Users;

namespace API.Controllers.UsersController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        internal readonly IMediator _mediator;
        internal readonly UserValidator _userValidator;

        public UsersController(IMediator mediator, UserValidator userValidator)
        {
            _mediator = mediator;
            _userValidator = userValidator;
        }

        [HttpPost("register")]
        [ProducesResponseType(typeof(UserCredentialsDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Errors), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromBody] UserCredentialsDto userToRegister)
        {
            var inputValidation = _userValidator.Validate(userToRegister);

            if (!inputValidation.IsValid)
            {
                return BadRequest(inputValidation.Errors.ConvertAll(errors => errors.ErrorMessage));
            }

            try
            {
                return Ok(await _mediator.Send(new RegisterUserCommand(userToRegister)));
            }
            catch (ArgumentException e)
            {
                //// Log the error and return an error response
                //_logger.LogError(e, "Error registering user");
                return BadRequest(e.Message);
            }
        }

        [HttpPost("login")]
        [ProducesResponseType(typeof(TokenDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Errors), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login([FromBody] UserCredentialsDto userToLogin)
        {
            var inputValidation = _userValidator.Validate(userToLogin);

            if (!inputValidation.IsValid)
            {
                return BadRequest(inputValidation.Errors.ConvertAll(errors => errors.ErrorMessage));
            }

            try
            {
                string token = await _mediator.Send(new LoginUserQuery(userToLogin));

                return Ok(new TokenDto { TokenValue = token });
            }
            catch (UnAuthorizedException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("GetUsersWithTheirAnimals")]
        public async Task<IActionResult> GetUsersWithTheirAnimals()
        {
            var command = new GetUsersWithAnimalsQuery();
            var usersWithAllTheirAnimals = await _mediator.Send(command);

            return Ok(usersWithAllTheirAnimals);
        }

        [HttpPost]
        [Route("addAnimalToUser")]
        public async Task<IActionResult> AddAnimalToUser([FromBody] AddAnimalToUserDto dto)
        {

            var userAnimalDto = new UserAnimalDto
            {
                UserId = dto.UserId,
                AnimalId = dto.AnimalId,
            };

            var command = new AddNewAnimalCommand(userAnimalDto);
            var success = await _mediator.Send(command);

            if (success)
            {
                return Ok("Animal added to user successfully");
            }
            else
            {
                return BadRequest("Failed to add animal to user");
            }
        }

        [HttpPut]
        [Route("updateUserAnimal")]
        public async Task<IActionResult> UpdateUserAnimal([FromBody] UpdateUserAnimalDto dto)
        {
            var validator = new UpdateUserAnimalDtoValidator();
            var validationResult = await validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(error => error.ErrorMessage);
                return BadRequest(errors);
            }

            var command = new UpdateUserAnimalCommand(dto.UserId, dto.OldAnimalId, dto.NewAnimalId);
            await _mediator.Send(command);

            return Ok("User's animal updated successfully");
        }

        [HttpDelete]
        [Route("deleteAnimalFromUser")]
        public async Task<IActionResult> DeleteAnimalFromUser([FromBody] DeleteAnimalFromUserDto dto)
        {
            var command = new DeleteAnimalByUserCommand(dto.UserId, dto.AnimalId);
            await _mediator.Send(command);

            return Ok("Animal deleted from user successfully");
        }

    }
}