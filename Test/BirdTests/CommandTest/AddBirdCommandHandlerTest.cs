using Application.Commands.Birds.AddBird;
using Application.Dtos;
using Domain.Models;
using Infrastructure.Repositories.Animal.Birds;
using Moq;

namespace Test.BirdTests.CommandTest
{
    [TestFixture]
    public class AddBirdCommandHandlerTest
    {
        private Application.Commands.Birds.AddBird.AddBirdCommandHandler? _handler;
        private Mock<IBirdRepository>? _birdRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _birdRepositoryMock = new Mock<IBirdRepository>();
            _handler = new Application.Commands.Birds.AddBird.AddBirdCommandHandler(_birdRepositoryMock.Object);
        }

        [Test]
        public async Task Handle_ShouldCreateBird()
        {
            //Arrange
            var birdDto = new BirdDto { Name = "NewBirdName", CanFly = true, Color = "Blue" };
            var command = new AddBirdCommand(birdDto);

            BirdDto createdBird = null!;
            _birdRepositoryMock!.Setup(repo => repo.CreateBirdAsync(It.IsAny<Bird>()))
                .Callback<Bird>(bird => createdBird = new BirdDto
                {
                    Name = bird.Name,
                    CanFly = bird.CanFly,
                    Color = bird.Color
                });

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            //Assert
            _birdRepositoryMock.Verify(repo => repo.CreateBirdAsync(It.IsAny<Bird>()), Times.Once);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo(birdDto.Name));
            Assert.That(result.CanFly, Is.EqualTo(birdDto.CanFly));
            Assert.That(result.Color, Is.EqualTo(birdDto.Color));
        }
    }
}