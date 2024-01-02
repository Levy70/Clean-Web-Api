using Application.Commands.Cats.AddCat;
using Domain.Models;
using Application.Dtos;
using Moq;
using Application.Commands.Cats;
using Infrastructure.Repositories.Animal.Cats;

namespace Test.CatTests.CommandTest
{
    [TestFixture]
    public class AddCatCommandHandlerTest
    {
        private AddCatCommandHandler? _handler;
        private Mock<ICatRepository>? _catRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _catRepositoryMock = new Mock<ICatRepository>();
            _handler = new AddCatCommandHandler(_catRepositoryMock.Object);
        }

        [Test]
        public async Task Handle_AddNewCatToDatabase()
        {
            //Arrange
            var catDto = new CatDto { Name = "NewCatName", LikesToPlay = true, Breed = "NewCatBreed", Weight = 8 };
            var command = new AddCatCommand(catDto);

            CatDto createdCat = null!;
            _catRepositoryMock!.Setup(repo => repo.CreateCatAsync(It.IsAny<Cat>()))
                .Callback<Cat>(cat => createdCat = new CatDto
                {
                    Name = cat.Name,
                    LikesToPlay = cat.LikesToPlay,
                    Breed = cat.Breed,
                    Weight = cat.Weight
                });

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo(catDto.Name));
            Assert.That(result.LikesToPlay, Is.EqualTo(catDto.LikesToPlay));
            Assert.That(result.Breed, Is.EqualTo(catDto.Breed));
        }
    }


}