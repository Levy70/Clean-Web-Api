using Application.Queries.Dogs.GetAll;
using Domain.Models;
using Infrastructure.Repositories.Animal.Dogs;
using Moq;

namespace Test.DogTests.QueryTest
{
    [TestFixture]
    public class GetAllDogsQueryHandlerTest
    {
        private Mock<IDogRepository>? _mockDogRepository;
        private GetAllDogsQueryHandler? _handler;

        [SetUp]
        public void SetUp()
        {
            _mockDogRepository = new Mock<IDogRepository>();
            _handler = new GetAllDogsQueryHandler(_mockDogRepository.Object);
        }

        [Test]
        public async Task Handle_ReturnsAllDogs()
        {
            //Arrange
            List<Dog> expectedDogs = new List<Dog>
            {
                new Dog { Id = Guid.NewGuid(), Name = "Nonika" },
                new Dog { Id = Guid.NewGuid(), Name = "Mandy" },
                new Dog { Id = Guid.NewGuid(), Name = "Alex" },
                new Dog { Id = Guid.NewGuid(), Name = "Pettibell" },
                new Dog { Id = Guid.NewGuid(), Name = "Oscar" },
            };

            _mockDogRepository!.Setup(repo => repo.GetAllDogsAsync()).ReturnsAsync(expectedDogs);

            //Act
            List<Dog> actualDogs = await _handler!.Handle(new GetAllDogsQuery(), CancellationToken.None);

            //Assert
            Assert.That(actualDogs, Is.EqualTo(expectedDogs));
        }
    }
}