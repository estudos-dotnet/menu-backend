using FluentAssertions;
using Menu.API.UnitTests.infrastructure;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace Menu.API.UnitTests
{
    public class HealthCheckTests : UnitTest
    {
        private HttpClient httpClient;

        [SetUp]
        public void Setup()
        {
            var hostBuilder = new WebApplicationFactory<Startup>();
            httpClient = hostBuilder.CreateDefaultClient();
        }

        [Test]
        public async Task WhenGetAsyncShouldReturnHealtyAsync()
        {
            var response = await httpClient.GetAsync("health");
            var content = await response.Content.ReadAsStringAsync();

            content.Should().Be("Healthy");
        }
    }
}