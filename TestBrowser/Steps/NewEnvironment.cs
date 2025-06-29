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
            IWebElement element;
            IWebElement ionListParent;
            IWebElement ionButtonsParent;
            string[] credentials = stepValue.Split(';');
            string[] properties = ["env", "clientName", "userName", "password", "url"];

            BrowserInstance.Navigate().GoToUrl(webUrl);
            BrowserInstance.Manage().Window.Size = new System.Drawing.Size(750, 1110);

            Thread.Sleep(40 * Constants.StandartWaitTime);
            ionListParent = BrowserInstance.FindElement(By.XPath("//*//ion-app/ion-modal/app-is-settings-form/ion-content/ion-row/ion-col/form/ion-list"));


            Thread.Sleep(20 * Constants.StandartWaitTime);

            for (int i = 0; i < properties.Length; i++)
            {
                element = ionListParent.FindElement(By.XPath("//ion-item/ion-input/label/div/input[contains(@name, '" + properties[i] + "')]"));
                element.SendKeys(credentials[i]);
            }

            ionButtonsParent = BrowserInstance.FindElement(By.XPath("//*//ion-app/ion-modal/app-is-settings-form/ion-footer/ion-toolbar/ion-buttons"));
            element = ionButtonsParent.FindElements(By.XPath(".//ion-button")).Last();
            element.Click();
            Thread.Sleep(Constants.StandartWaitTime);

            return true;

        }
    }
}
