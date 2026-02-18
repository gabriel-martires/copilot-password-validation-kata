using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace CopilotPasswordValidationKata.IntegrationTests;

public class HealthEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public HealthEndpointTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetHealth_ReturnsOk()
    {
        // Act
        var response = await _client.GetAsync("/health");

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task GetHealth_ReturnsStatusOk()
    {
        // Act
        var response = await _client.GetAsync("/health");
        var healthResponse = await response.Content.ReadFromJsonAsync<HealthResponse>();

        // Assert
        Assert.NotNull(healthResponse);
        Assert.Equal("ok", healthResponse.Status);
    }
}

public record HealthResponse
{
    public string Status { get; init; } = string.Empty;
}
