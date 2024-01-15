using Application.Queries.Birds.GetAll;
using Domain.Models;
using Infrastructure.Repositories.Animal.Birds;
using Moq;

namespace Test.BirdTests.QueryTest
{
    [TestFixture]
    public class GetAllBirdsQueryHandlerTest
    {
        private Mock<IBirdRepository> _mockBirdRepository;
        private GetAllBirdsQueryHandler _handler;

        [SetUp]
        public void SetUp()
        {
            _mockBirdRepository = new Mock<IBirdRepository>();
            _handler = new GetAllBirdsQueryHandler(_mockBirdRepository.Object);
        }

        [Test]
        public async Task Handle_ReturnsAllBirds()
        {
            //Arrange
            List<Bird> expectedBirds = new List<Bird>
            {
                new Bird { Id = Guid.NewGuid(), Name = "Fench" },
                new Bird { Id = Guid.NewGuid(), Name = "Owl" },
                new Bird { Id = Guid.NewGuid(), Name = "LittePitte" },
                new Bird { Id = Guid.NewGuid(), Name = "LovlyBoy" },
                new Bird { Id = Guid.NewGuid(), Name = "Tittu" },
            };

            _mockBirdRepository.Setup(repo => repo.GetAllBirdsAsync()).ReturnsAsync(expectedBirds);


            //Act
            List<Bird> actualBirds = await _handler.Handle(new GetAllBirdsQuery(), CancellationToken.None);

            //Assert
            Assert.That(actualBirds, Is.EqualTo(expectedBirds));
        }
    }
}