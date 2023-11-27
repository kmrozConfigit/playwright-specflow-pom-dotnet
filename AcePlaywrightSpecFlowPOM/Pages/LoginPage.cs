using Microsoft.Playwright;

namespace PlaywrightSpecFlowPOM.Pages;

public class LoginPage
{
    public readonly IPage Page;
    public readonly string UrlRegexMicrosoft = "https://login.microsoftonline.com/**";

    public LoginPage(Hooks.Hooks hooks)
    {
        Page = hooks.Page;
    }

    public ILocator ButtonSignInWithAzure => Page.Locator("//button[. = 'Sign in with Microsoft Entra ID']");
    public ILocator InputLogin => Page.Locator("xpath=//input[@name = 'loginfmt']");
    public ILocator ButtonSubmit => Page.Locator("input[type = 'submit']");
    public ILocator InputPassword => Page.Locator("input[type = 'password']");
    public ILocator ButtonYes => Page.Locator("input[value = 'Yes']");
}