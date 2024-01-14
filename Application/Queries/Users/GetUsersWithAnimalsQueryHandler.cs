using Domain.Models;
using Microsoft.Extensions.Logging;
using MediatR;
using Infrastructure.Repositories.Users;

namespace Application.Queries.Users
{
    internal class GetUsersWithAnimalsQueryHandler : IRequestHandler<GetUsersWithAnimalsQuery, List<object>>
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<GetUsersWithAnimalsQueryHandler> _logger;

        public GetUsersWithAnimalsQueryHandler(IUserRepository userRepository, ILogger<GetUsersWithAnimalsQueryHandler> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<List<object>> Handle(GetUsersWithAnimalsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                List<UserAnimal> usersWithAnimals = await _userRepository.GetAllUsersWithAnimals();

                var usersWithAllTheirAnimals = usersWithAnimals
                    .GroupBy(u => u.Animal)
                    .Select(g => new
                    {
                        UserName = g.Key,
                        Animals = g.Select(userAnimal => new
                        {
                            userAnimal.UserId,
                            userAnimal.Animal,
                            userAnimal.AnimalId

                        }).ToList()
                    })
                    .ToList<object>();

                return usersWithAllTheirAnimals.Cast<object>().ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while fetching users with animals", ex);
                throw;
            }
        }
    }
}
