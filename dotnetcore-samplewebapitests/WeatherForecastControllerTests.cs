using System.Linq;
using Xunit;
using dotnetcore_samplewebapi.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
namespace Tests
{
    public class WeatherForecastControllerTests
    {
        private Mock<ILogger<WeatherForecastController>> loggerStub = new Mock<ILogger<WeatherForecastController>>();

        [Fact]
        public void Get_NoArguments_ReturnsDefaultForecastDays()
        {
            var controller = new WeatherForecastController(loggerStub.Object);
            var expectedDays = 5;

            var forecasts = controller.Get();

            Assert.NotNull(forecasts);
            Assert.Equal(expectedDays, forecasts.Count());
        }
    }
}