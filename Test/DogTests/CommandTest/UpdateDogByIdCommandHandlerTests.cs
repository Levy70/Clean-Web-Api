using Application.Commands.Dogs.UpdateDog;
using Application.Dtos;
using Domain.Models;
using Infrastructure.Repositories.Animal.Dogs;
using Moq;

namespace Test.DogTests.CommandTest
{
    [TestFixture]
    public class UpdateDogByIdCommandHandlerTest
    {
        private UpdateDogByIdCommandHandler? _handler;
        private Mock<IDogRepository>? _dogRepositoryMock;
        [SetUp]
        public void SetUp()
        {
            _dogRepositoryMock = new Mock<IDogRepository>();
            _handler = new UpdateDogByIdCommandHandler(_dogRepositoryMock.Object);
        }

        [Test]
        public async Task Handle_UpdateDogByIdInDatabase()
        {
            //Arrange
            var dogId = Guid.NewGuid();
            var dogToUpdate = new Dog { Id = dogId, Name = "Test", Breed = "TestBreed", Weight = 6 };
            var updatedDogDto = new DogDto { Name = "Updated", Breed = "UpdatedBreed", Weight = 10 };

            var command = new UpdateDogByIdCommand(updatedDogDto, dogId);
            _dogRepositoryMock!.Setup(repo => repo.GetDogByIdAsync(dogId)).ReturnsAsync(dogToUpdate);
            _dogRepositoryMock!.Setup(repo => repo.UpdateDogByIdAsync(dogId)).ReturnsAsync(dogToUpdate);

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            //Assert
            _dogRepositoryMock.Verify(repo => repo.GetDogByIdAsync(dogId), Times.Once);
            _dogRepositoryMock.Verify(repo => repo.UpdateDogByIdAsync(dogId), Times.Once);
            Assert.That(result, Is.EqualTo(dogToUpdate));

        }
        [Test]
        public async Task Handle_WhenNotExist_ShouldThrowException()
        {
            //Arrange
            var dogId = Guid.NewGuid();
            var updatedDogDto = new DogDto { Name = "Updated", Breed = "UpdatedBreed", Weight = 10 };
            var command = new UpdateDogByIdCommand(updatedDogDto, dogId);
            _dogRepositoryMock!.Setup(repo => repo.GetDogByIdAsync(dogId)).ReturnsAsync((Dog?)null);

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            //Assert
            _dogRepositoryMock.Verify(repo => repo.GetDogByIdAsync(dogId), Times.Once);
            _dogRepositoryMock.Verify(repo => repo.UpdateDogByIdAsync(dogId), Times.Never);
            Assert.That(result, Is.Null);
        }
    }

}