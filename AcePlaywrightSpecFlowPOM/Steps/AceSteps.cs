using Microsoft.Playwright;
using PlaywrightSpecFlowPOM.Pages;
using FluentAssertions;

namespace PlaywrightSpecFlowPOM.Steps;

[Binding]
public class AceSteps
{
    private readonly IPage _page;
    private readonly DefaultPage _defaultPage;

    public AceSteps(Hooks.Hooks hooks, DefaultPage defaultPage)
    {
        _page = hooks.Page;
        _defaultPage = defaultPage;
    }

    [Given(@"Ace boarding page opened")]
    public async Task GivenAceBoardingPageOpened()
    {
        await Assertions.Expect(_defaultPage.ButtonNewWorkItem)
            .ToBeVisibleAsync(new LocatorAssertionsToBeVisibleOptions() { Visible = true, Timeout = 25000 });
        await Assertions.Expect(_defaultPage.ListRecentPackages)
            .ToBeVisibleAsync(new LocatorAssertionsToBeVisibleOptions() { Visible = true, Timeout = 25000 });
    }
}