using Microsoft.AspNetCore.Mvc.Testing;
using BookingCalendar.Api;

namespace BookingCalendar.Api.Tests;

public class ApiSmokeTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public ApiSmokeTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task App_StartsAndResponds()
    {
        var response = await _client.GetAsync("/");
        Assert.NotEqual(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
    }
}