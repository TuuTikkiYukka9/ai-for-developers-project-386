using Bunit;
using BookingCalendar.Client;
using BookingCalendar.Client.Pages;
using Xunit;

namespace BookingCalendar.Client.Tests;

public class ClientSmokeTests : BunitContext
{
    [Fact]
    public void App_RendersWithoutCrashing()
    {
        var cut = Render<App>();
        Assert.NotNull(cut);
    }

    [Fact]
    public void Counter_RendersCorrectly()
    {
        var cut = Render<Counter>();
        Assert.Contains("Current count:", cut.Markup);
    }
}