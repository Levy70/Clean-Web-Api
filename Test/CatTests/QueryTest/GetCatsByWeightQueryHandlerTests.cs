using Application.Queries.Cats.GetCatsByWeight;
using Domain.Models;
using Infrastructure.Repositories.Animal.Cats;
using Moq;

namespace Test.CatTests.QueryTest
{
    [TestFixture]
    public class GetCatsByWeightQueryHandlerTests
    {
        private Mock<ICatRepository>? _catRepositoryMock;
        private GetCatsByWeightQueryHandler? _handler;

        [SetUp]
        public void SetUp()
        {
            _catRepositoryMock = new Mock<ICatRepository>();
            _handler = new GetCatsByWeightQueryHandler(_catRepositoryMock.Object);
        }

        [Test]
        public async Task GetCatsByWeightQueryHandler_ShouldReturnListOfCats_WhenCatsExist()
        {
            // Arrange
            var weight = 10;
            var cats = new List<Cat> { new Cat { Weight = weight } };
            _catRepositoryMock!.Setup(repo => repo.GetAllCatsAsync()).ReturnsAsync(cats);

            // Act
            var result = await _handler!.Handle(new GetCatsByWeightQuery(weight), CancellationToken.None);

            // Assert
            Assert.That(result, Is.EqualTo(cats));

        }
    }
}