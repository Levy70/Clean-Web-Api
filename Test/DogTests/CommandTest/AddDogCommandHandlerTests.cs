using Application.Commands.Dogs;
using Application.Dtos;
using Domain.Models;
using Infrastructure.Repositories.Animal.Dogs;
using Moq;

namespace Test.DogTests.CommandTest
{
    [TestFixture]
    public class AddDogCommandHandlerTest
    {
        private AddDogCommandHandler? _handler;
        private Mock<IDogRepository>? _dogRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _dogRepositoryMock = new Mock<IDogRepository>();
            _handler = new AddDogCommandHandler(_dogRepositoryMock.Object);
        }

        [Test]
        public async Task Handle_AddNewDogToDatabase()
        {
            //Arrange
            var dogDto = new DogDto { Name = "NewDogName", Breed = "NewDogBreed", Weight = 9 };
            var command = new AddDogCommand(dogDto);

            DogDto createdDog = null!;
            _dogRepositoryMock!.Setup(repo => repo.CreateDogAsync(It.IsAny<Dog>()))
                .Callback<Dog>(dog => createdDog = new DogDto
                {
                    Name = dog.Name,
                    Breed = dog.Breed,
                    Weight = dog.Weight
                });

            //Act
            var result = await _handler!.Handle(command, CancellationToken.None);

            //Assert
            _dogRepositoryMock.Verify(repo => repo.CreateDogAsync(It.IsAny<Dog>()), Times.Once);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo(dogDto.Name));
            Assert.That(result.Breed, Is.EqualTo(dogDto.Breed));
            Assert.That(result.Weight, Is.EqualTo(dogDto.Weight));
        }
    }
}
