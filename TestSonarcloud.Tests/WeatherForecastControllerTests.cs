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
        public void Test()
        {
            var result = _weatherForecastService.Get();

            CollectionAssert.IsNotEmpty(result, "Collection should not be empty");
        }

        [Test]
        public void Test1()
        {
            var result = _weatherForecastService.Get1();

            CollectionAssert.IsNotEmpty(result, "Collection should not be empty");
        }

        [Test]
        public void Test2()
        {
            var result = _weatherForecastService.Get2();

            CollectionAssert.IsNotEmpty(result, "Collection should not be empty");
        }


    }
}