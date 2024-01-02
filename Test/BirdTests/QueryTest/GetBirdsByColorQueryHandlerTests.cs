using Application.Queries.Birds.GetByColor;
using Domain.Models;
using Infrastructure.Repositories.Animal.Birds;
using Moq;

namespace Test.BirdTests.QueryTest
{
    public class GetBirdsByColorQueryHandlerTests
    {
        private Mock<IBirdRepository>? _birdRepositoryMock;
        private GetBirdsByColorQueryHandler? _handler;
        [SetUp]
        public void SetUp()
        {
            _birdRepositoryMock = new Mock<IBirdRepository>();
            _handler = new GetBirdsByColorQueryHandler(_birdRepositoryMock.Object);
        }
        [Test]
        public async Task Handle_WhenBirdsExistWithColor_ShouldReturnBirds()
        {
            // Arrange
            var color = "Test";
            var birds = new List<Bird>
            {
                new Bird { Color = color },
                new Bird { Color = color },
                new Bird { Color = "ColorTest" }
            };
            var query = new GetBirdsByColorQuery(color);
            _birdRepositoryMock!.Setup(repo => repo.GetAllBirdsAsync()).ReturnsAsync(birds);

            // Act
            var result = await _handler!.Handle(query, CancellationToken.None);

            // Assert
            Assert.That(result, Is.Not.Null);
        }
        [Test]
        public async Task Handle_WhenBirdsDoesNotExistWithColor_ShouldReturnEmpty()
        {
            // Arrange
            var color = "Blue";
            var birds = new List<Bird>
            {
                new Bird { Color = "Red" },
                new Bird { Color = "Pink" },
                new Bird { Color = "Green" }
            };
            var query = new GetBirdsByColorQuery(color);
            _birdRepositoryMock!.Setup(repo => repo.GetAllBirdsAsync()).ReturnsAsync(birds);

            // Act
            var result = await _handler!.Handle(query, CancellationToken.None);

            // Assert
            Assert.That(result, Is.Empty);
        }
    }
}