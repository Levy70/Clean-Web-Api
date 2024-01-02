using Application.Commands.Birds.UpdateBird;
using Application.Dtos;
using Domain.Models;
using Infrastructure.Repositories.Animal.Birds;
using Moq;

namespace Test.BirdTests.CommandTest
{
    [TestFixture]
    public class UpdateBirdByIdCommandHandlerTest
    {
        private UpdateBirdByIdCommandHandler? _handler;
        private Mock<IBirdRepository>? _birdRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _birdRepositoryMock = new Mock<IBirdRepository>();
            _handler = new UpdateBirdByIdCommandHandler(_birdRepositoryMock.Object);
        }

        [Test]
        public async Task Handle_WhenExist_ShouldUpdateBird()
        {
            //Arrange
            var birdId = Guid.NewGuid();
            var birdToUpdate = new Bird { Id = birdId, Name = "Test", CanFly = true };
            var updatedBirdDto = new BirdDto { Name = "Updated", CanFly = false, Color = "UpdatedColor" };
            var command = new UpdateBirdByIdCommand(birdId, updatedBirdDto);
            _birdRepositoryMock!.Setup(repo => repo.GetBirdByIdAsync(birdId)).ReturnsAsync(birdToUpdate);
            _birdRepositoryMock!.Setup(repo => repo.UpdateBirdByIdAsync(birdId)).ReturnsAsync(birdToUpdate);

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            //Assert
            _birdRepositoryMock.Verify(repo => repo.GetBirdByIdAsync(birdId), Times.Once);
            _birdRepositoryMock.Verify(repo => repo.UpdateBirdByIdAsync(birdId), Times.Once);
            Assert.That(result, Is.EqualTo(birdToUpdate));

        }
        [Test]
        public async Task Handle_WhenNotExist_ShouldThrowException()
        {
            //Arrange
            var birdId = Guid.NewGuid();
            var updatedBirdDto = new BirdDto { Name = "Updated", CanFly = false, Color = "UpdatedColor" };
            var command = new UpdateBirdByIdCommand(birdId, updatedBirdDto);
            _birdRepositoryMock!.Setup(repo => repo.GetBirdByIdAsync(birdId)).ReturnsAsync((Bird?)null);

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            //Assert
            _birdRepositoryMock.Verify(repo => repo.GetBirdByIdAsync(birdId), Times.Once);
            _birdRepositoryMock.Verify(repo => repo.UpdateBirdByIdAsync(birdId), Times.Never);
            Assert.That(result, Is.Null);
        }
    }
}
