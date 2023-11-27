using Microsoft.Playwright;

namespace PlaywrightSpecFlowPOM.Hooks
{
    [Binding]
    public class Hooks
    {
        public IPage Page { get; private set; } = null!;

        [BeforeScenario]
        public async Task RegisterSingleInstancePractitioner()
        {
            //Initialise Playwright
            var playwright = await Playwright.CreateAsync();
            //Initialise a browser - 'Chromium' can be changed to 'Firefox' or 'Webkit'
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                Timeout = 30000
            });
            //Setup a browser context
            var context = await browser.NewContextAsync(new BrowserNewContextOptions()
                { ViewportSize = new ViewportSize() { Width = 800, Height = 600 }, IgnoreHTTPSErrors = true });
            //Initialise a page on the browser context.
            Page = await context.NewPageAsync();
        }
    }
}