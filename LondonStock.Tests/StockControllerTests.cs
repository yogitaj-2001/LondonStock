using LondonStock.Controllers;
using LondonStock.Service;
using LondonStock.Tests.MockData;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace LondonStock.Tests
{
    public class StockControllerTests
    {
        [Fact]
        public async Task GetAllStocks_ShouldReturn200Status()
        {
            /// Arrange
            var  service= new Mock<ILondonStockService>();
            service.Setup(_ => _.GetAllStocks()).ReturnsAsync(LondonStockMockData.GetStock());
            var controller = new StocksController(service.Object);

            /// Act
            var result = await controller.GetAllStocks();

            /// Assert
            Assert.IsType<OkObjectResult>(result.Result);
        }

        // TODO: similar tests can be added for other endpoints
        // TODO: automated api tests of BDD style can be added using cucumber/gherkin
    }
}