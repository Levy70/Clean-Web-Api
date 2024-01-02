using Application.Queries.Dogs.GetDogsByWeight;
using Domain.Models;
using Infrastructure.Repositories.Animal.Dogs;
using Moq;

namespace Test.DogTests.QueryTest
{
    [TestFixture]
    public class GetDogsByWeightQueryHandlerTests
    {
        private Mock<IDogRepository>? _dogRepositoryMock;
        private GetDogsByWeightQueryHandler? _handler;

        [SetUp]
        public void SetUp()
        {
            _dogRepositoryMock = new Mock<IDogRepository>();
            _handler = new GetDogsByWeightQueryHandler(_dogRepositoryMock.Object);
        }

        [Test]
        public async Task GetDogsByWeightQueryHandler_ShouldReturnListOfDogs_WhenDogsExist()
        {
            // Arrange
            var weight = 10;
            var dogs = new List<Dog> { new Dog { Weight = weight } };
            _dogRepositoryMock!.Setup(repo => repo.GetAllDogsAsync()).ReturnsAsync(dogs);

            // Act
            var result = await _handler!.Handle(new GetDogsByWeightQuery(weight), CancellationToken.None);

            // Assert
            Assert.That(result, Is.EqualTo(dogs));
        }
    }
}
