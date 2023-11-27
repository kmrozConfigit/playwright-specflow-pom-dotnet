using Microsoft.Playwright;
using PlaywrightSpecFlowPOM.Pages;
using FluentAssertions;

namespace PlaywrightSpecFlowPOM.Steps;

[Binding]
public class CommonSteps
{
    private readonly IPage _page;

    public CommonSteps(Hooks.Hooks hooks)
    {
        _page = hooks.Page;
    }

    [Given(@"Breakpoint")]
    public async Task Breakpoint()
    {
        await _page.PauseAsync();
    }

    [Given(@"Wait (.*) seconds")]
    public async Task WaitSeconds(int seconds)
    {
        await _page.WaitForTimeoutAsync(seconds * 1000);
    }
}