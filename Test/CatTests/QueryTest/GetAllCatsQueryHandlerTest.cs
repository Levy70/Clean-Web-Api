using Application.Queries.Cats.GetAll;
using Domain.Models;
using Infrastructure.Repositories.Animal.Cats;
using Moq;

namespace Test.CatTests.QueryTest
{
    [TestFixture]
    public class GetAllCatsQueryHandlerTest
    {
        private Mock<ICatRepository> _mockCatRepository;
        private GetAllCatsQueryHandler _handler;

        [SetUp]
        public void SetUp()
        {
            _mockCatRepository = new Mock<ICatRepository>();
            _handler = new GetAllCatsQueryHandler(_mockCatRepository.Object);
        }

        [Test]
        public async Task Handle_GetAllCats_FromDatabase_ReturnsCorrect()
        {
            //Arrange
            List<Cat> expectedCats = new List<Cat>
            {
                new Cat { Id = Guid.NewGuid(), Name = "Sezar" },
                new Cat { Id = Guid.NewGuid(), Name = "Simba" },
                new Cat { Id = Guid.NewGuid(), Name = "Misholak" },
                new Cat { Id = Guid.NewGuid(), Name = "Kattis" },
                new Cat { Id = Guid.NewGuid(), Name = "Lotta" },
            };

            _mockCatRepository.Setup(repo => repo.GetAllCatsAsync()).ReturnsAsync(expectedCats);

            //Act
            List<Cat> actualCats = await _handler.Handle(new GetAllCatsQuery(), CancellationToken.None);

            //Assert
            Assert.That(actualCats, Is.EqualTo(expectedCats));
        }
    }
}
