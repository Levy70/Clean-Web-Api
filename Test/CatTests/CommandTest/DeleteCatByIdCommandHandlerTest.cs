using Application.Commands.Cats.DeleteCat;
using Domain.Models;
using Infrastructure.Repositories.Animal.Cats;
using Moq;

namespace Test.CatTests.CommandTest
{
    [TestFixture]
    public class DeleteCatByIdCommandHandlerTest
    {
        private DeleteCatByIdCommandHandler? _handler;
        private Mock<ICatRepository>? _catRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _catRepositoryMock = new Mock<ICatRepository>();
            _handler = new DeleteCatByIdCommandHandler(_catRepositoryMock.Object);
        }

        [Test]
        public async Task Handle_ShouldDeleteCat()
        {
            // Arrange
            var catId = Guid.NewGuid();
            var catToDelete = new Cat { Id = catId, Name = "Test", LikesToPlay = true, Breed = "TestBreed", Weight = 10 };
            var command = new DeleteCatByIdCommand(catId);

            _catRepositoryMock!.Setup(repo => repo.GetCatByIdAsync(catId)).ReturnsAsync(catToDelete);
            _catRepositoryMock!.Setup(repo => repo.DeleteCatByIdAsync(catId)).ReturnsAsync(catToDelete);

            // Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            // Assert
            _catRepositoryMock.Verify(repo => repo.GetCatByIdAsync(catId), Times.Once);
            _catRepositoryMock.Verify(repo => repo.DeleteCatByIdAsync(catId), Times.Once);
            Assert.That(result, Is.EqualTo(catToDelete));
        }

        [Test]
        public async Task Handle_WhenCatDoesNotExist_ShouldThrowNotFoundException()
        {
            // Arrange
            var catId = Guid.NewGuid();
            var command = new DeleteCatByIdCommand(catId);

            _catRepositoryMock!.Setup(repo => repo.GetCatByIdAsync(catId)).ReturnsAsync((Cat?)null);
            _catRepositoryMock!.Setup(repo => repo.DeleteCatByIdAsync(catId)).ReturnsAsync((Cat?)null);

            // Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            // Assert
            _catRepositoryMock.Verify(repo => repo.GetCatByIdAsync(catId), Times.Once);
            _catRepositoryMock.Verify(repo => repo.DeleteCatByIdAsync(It.IsAny<Guid>()), Times.Never);
            Assert.That(result, Is.Null);
        }
    }
}
