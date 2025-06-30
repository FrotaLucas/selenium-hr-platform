using OpenQA.Selenium;

namespace TestBrowser.Steps
{
    internal class NewEnvironment : StepBase
    {
        private readonly string webUrl;

        public NewEnvironment(string webUrl) : base("newEnvironment")
        {
            this.webUrl = webUrl;
        }

        public override bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath)
        {

            BrowserInstance.Navigate().GoToUrl(webUrl);

            Thread.Sleep(40 * Constants.StandartWaitTime);

            return true;

        }
    }
}
