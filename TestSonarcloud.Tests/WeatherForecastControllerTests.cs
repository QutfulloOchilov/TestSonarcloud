using NUnit.Framework;
using TestSonarcloud.Services;

namespace TestSonarcloud.Tests
{
    public class WeatherForecastControllerTests
    {
        WeatherForecastService _weatherForecastService;

        [SetUp]
        public void Setup()
        {
            _weatherForecastService = new WeatherForecastService();
        }

        [Test]
        public void Test1()
        {
            var result = _weatherForecastService.Get();

            CollectionAssert.IsNotEmpty(result);
        }


        [Test]
        public void Test2()
        {
           Assert.Fail("Test build");
        }
    }
}