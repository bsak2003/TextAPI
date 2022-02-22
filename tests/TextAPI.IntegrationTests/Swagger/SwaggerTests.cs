using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using TextAPI.IntegrationTests.Helpers;
using Xunit;

namespace TextAPI.IntegrationTests.Swagger;

public class SwaggerTests : IClassFixture<WebAppFactory>
{
    private readonly WebAppFactory _factory;

    public SwaggerTests(WebAppFactory factory)
    {
        _factory = factory;
    }

    [Theory]
    [InlineData("/swagger")]
    [InlineData("/swagger/v1/swagger.json")]
    public async Task DoesSwaggerWork(string url)
    {
        var client = _factory.CreateClient();

        var response = await client.GetAsync(url);

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}