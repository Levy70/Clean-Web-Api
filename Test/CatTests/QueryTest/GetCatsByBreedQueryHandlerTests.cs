using Application.Queries.Cats.GetCatsByBreed;
using Domain.Models;
using Infrastructure.Repositories.Animal.Cats;
using Moq;

namespace Test.CatTests.QueryTest
{
    [TestFixture]
    public class GetCatsByBreedQueryHandlerTests
    {
        private Mock<ICatRepository>? _mockCatRepository;
        private GetCatsByBreedQueryHandler? _breedHandler;

        [SetUp]
        public void SetUp()
        {
            _mockCatRepository = new Mock<ICatRepository>();
            _breedHandler = new GetCatsByBreedQueryHandler(_mockCatRepository.Object);
        }
        [Test]
        public async Task GetCatsByBreedQueryHandler_ShouldReturnListOfCats()
        {
            // Arrange
            var breed = "Birman";
            var cats = new List<Cat> { new Cat { Breed = breed } };
            _mockCatRepository!.Setup(repo => repo.GetAllCatsAsync()).ReturnsAsync(cats);

            // Act
            var result = await _breedHandler!.Handle(new GetCatsByBreedQuery(breed), default);

            // Assert
            Assert.That(result, Is.EqualTo(cats));
        }
    }
}