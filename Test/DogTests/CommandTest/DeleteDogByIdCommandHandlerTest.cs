using Application.Commands.Dogs.DeleteDog;
using Domain.Models;
using Infrastructure.Repositories.Animal.Dogs;
using Moq;

namespace Test.DogTests.CommandTest
{
    [TestFixture]
    public class DeleteDogByIdCommandHandlerTest
    {
        private DeleteDogByIdCommandHandler? _handler;
        private Mock<IDogRepository>? _dogRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _dogRepositoryMock = new Mock<IDogRepository>();
            _handler = new DeleteDogByIdCommandHandler(_dogRepositoryMock.Object);
        }
        [Test]
        public async Task Handle_ShouldDeleteDog()
        {
            //Arrange
            var dogId = Guid.NewGuid();
            var dogToDelete = new Dog { Id = dogId, Name = "Test", Breed = "TestBreedDog", Weight = 8 };
            var command = new DeleteDogByIdCommand(dogId);

            _dogRepositoryMock!.Setup(repo => repo.GetDogByIdAsync(dogId)).ReturnsAsync(dogToDelete);
            _dogRepositoryMock!.Setup(repo => repo.DeleteDogByIdAsync(dogId)).ReturnsAsync(dogToDelete);

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);


            //Assert
            _dogRepositoryMock.Verify(repo => repo.GetDogByIdAsync(dogId), Times.Once);
            _dogRepositoryMock.Verify(repo => repo.DeleteDogByIdAsync(dogId), Times.Once);
            Assert.That(result, Is.EqualTo(dogToDelete));
        }
        [Test]
        public async Task Handle_WhenDogDoesNotExist_ShouldThrowNotFoundException()
        {
            //Arrange
            var dogId = Guid.NewGuid();
            var command = new DeleteDogByIdCommand(dogId);

            _dogRepositoryMock!.Setup(repo => repo.GetDogByIdAsync(dogId)).ReturnsAsync((Dog?)null);
            _dogRepositoryMock!.Setup(repo => repo.DeleteDogByIdAsync(dogId)).ReturnsAsync((Dog?)null);

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            //Assert
            _dogRepositoryMock.Verify(repo => repo.GetDogByIdAsync(dogId), Times.Once);
            _dogRepositoryMock.Verify(repo => repo.DeleteDogByIdAsync(dogId), Times.Never);
            Assert.That(result, Is.Null);
        }
    }
}
