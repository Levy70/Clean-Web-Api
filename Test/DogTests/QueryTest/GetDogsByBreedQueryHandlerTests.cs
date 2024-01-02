using Application.Queries.Dogs.GetDogsByBreed;
using Domain.Models;
using Infrastructure.Repositories.Animal.Dogs;
using Moq;

namespace Test.DogTests.QueryTest
{
    [TestFixture]
    public class GetDogsByBreedQueryHandlerTests
    {
        private Mock<IDogRepository>? _mockDogRepository;
        private GetDogsByBreedQueryHandler? _breedHandler;

        [SetUp]
        public void SetUp()
        {
            _mockDogRepository = new Mock<IDogRepository>();
            _breedHandler = new GetDogsByBreedQueryHandler(_mockDogRepository.Object);
        }
        [Test]
        public async Task GetDogsByBreedQueryHandler_ShouldReturnListOfDogs()
        {
            // Arrange
            var breed = "Chihuahua";
            var dogs = new List<Dog> { new Dog { Breed = breed } };
            _mockDogRepository!.Setup(repo => repo.GetAllDogsAsync()).ReturnsAsync(dogs);

            // Act
            var result = await _breedHandler!.Handle(new GetDogsByBreedQuery(breed), default);

            // Assert
            Assert.That(result, Is.EqualTo(dogs));
        }
    }
}
