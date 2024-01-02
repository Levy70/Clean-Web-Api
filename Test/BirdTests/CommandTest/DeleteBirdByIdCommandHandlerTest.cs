using Application.Commands.Birds.DeleteBird;
using Moq;
using Domain.Models;
using Infrastructure.Repositories.Animal.Birds;

namespace Test.BirdTests.CommandTest
{
    [TestFixture]
    public class DeleteBirdByIdCommandHandlerTest
    {
        private DeleteBirdByIdCommandHandler? _handler;
        private Mock<IBirdRepository>? _birdRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _birdRepositoryMock = new Mock<IBirdRepository>();
            _handler = new DeleteBirdByIdCommandHandler(_birdRepositoryMock.Object);
        }

        [Test]
        public async Task Handle_ShouldDeleteBird()
        {
            // Arrange
            var birdId = Guid.NewGuid();
            var birdToDelete = new Bird { Id = birdId, Name = "Test", CanFly = true };
            var command = new DeleteBirdByIdCommand(birdId);

            _birdRepositoryMock!.Setup(repo => repo.GetBirdByIdAsync(birdId)).ReturnsAsync(birdToDelete);
            _birdRepositoryMock!.Setup(repo => repo.DeleteBirdByIdAsync(birdId)).ReturnsAsync(birdToDelete);

            // Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            // Assert
            _birdRepositoryMock.Verify(repo => repo.GetBirdByIdAsync(birdId), Times.Once);
            _birdRepositoryMock.Verify(repo => repo.DeleteBirdByIdAsync(birdId), Times.Once);
            Assert.That(result, Is.EqualTo(birdToDelete));
        }
        [Test]
        public async Task Handle_WhenBirdDoesNotExist_ShouldThrowNotFoundException()
        {
            // Arrange
            var birdId = Guid.NewGuid();

            var command = new DeleteBirdByIdCommand(birdId);

            _birdRepositoryMock!.Setup(repo => repo.GetBirdByIdAsync(birdId)).ReturnsAsync((Bird?)null);
            _birdRepositoryMock!.Setup(repo => repo.DeleteBirdByIdAsync(birdId)).ReturnsAsync((Bird?)null);

            // Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            // Assert
            _birdRepositoryMock.Verify(repo => repo.GetBirdByIdAsync(birdId), Times.Once);
            _birdRepositoryMock.Verify(repo => repo.DeleteBirdByIdAsync(birdId), Times.Never);
            Assert.That(result, Is.Null);






        }
    }
}
