using InfraStructure.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using StarsWarsWebapi.Controllers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StarsWarsApi.UnitTests
{
    public class StarsWarsControllerTests
    {
        [Fact]
        public async Task GetPeople_ReturnsOkObjectResult()
        {
            // Arrange
            string fakeApiResponse = "https://swapi.dev/api/people/";
            var starWarsApiServiceMock = new Mock<StarWarsApiService>();
            starWarsApiServiceMock.Setup(service => service.GetPeople()).ReturnsAsync(fakeApiResponse);

            var controller = new StarsWarsController(starWarsApiServiceMock.Object);

            // Act
            IActionResult result = await controller.GetPeople();

            // Assert
            Assert.IsType<OkObjectResult>(result);

            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, okResult.StatusCode);

            var responseData = Assert.IsType<string>(okResult.Value);
            Assert.Equal(fakeApiResponse, responseData);
        }
    }
}
