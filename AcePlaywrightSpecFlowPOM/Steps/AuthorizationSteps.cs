using PlaywrightSpecFlowPOM.Pages;
using Microsoft.Playwright;
using FluentAssertions;

namespace PlaywrightSpecFlowPOM.Steps;

[Binding]
public class AuthorizationSteps
{
    private readonly IPage _page;
    private readonly LoginPage _loginPage;

    public AuthorizationSteps(Hooks.Hooks hooks, LoginPage loginPage)
    {
        _page = hooks.Page;
        _loginPage = loginPage;
    }

    [Given(@"Login as '(.*)' to the Ace application '(.*)'")]
    public async Task LoginAsUserToTheAceApplication(string user, string url)
    {
        await _page.GotoAsync(url);
        await Assertions.Expect(_loginPage.ButtonSignInWithAzure).ToBeVisibleAsync();
        await _loginPage.ButtonSignInWithAzure.ClickAsync();
        await _loginPage.Page.WaitForURLAsync(_loginPage.UrlRegexMicrosoft);
        await _loginPage.InputLogin.FillAsync(user);
        await _loginPage.ButtonSubmit.ClickAsync();
        await _loginPage.InputPassword.FillAsync("*******"); // TODO: set correct password
        await _loginPage.ButtonSubmit.ClickAsync();
        await _loginPage.ButtonYes.ClickAsync();
    }
}