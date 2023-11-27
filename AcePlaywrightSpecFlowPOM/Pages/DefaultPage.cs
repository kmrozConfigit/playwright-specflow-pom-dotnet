using Microsoft.Playwright;

namespace PlaywrightSpecFlowPOM.Pages;

public class DefaultPage
{
    public readonly IPage Page;

    public DefaultPage(Hooks.Hooks hooks)
    {
        Page = hooks.Page;
    }

    public ILocator ButtonNewWorkItem => Page.Locator("xpath=//button[text() = 'New work item']");

    public ILocator ListRecentPackages =>
        Page.Locator("xpath=//div[contains(@class, 'list')]//div[text()= 'Recent packages']");
}