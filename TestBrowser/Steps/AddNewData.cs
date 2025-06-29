using OpenQA.Selenium;

namespace TestBrowser.Steps
{
    internal class AddNewData : StepBase
    {
        public AddNewData() : base("addNewDataItem")
        {
        }

        public override bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath)
        {
            IWebElement element;

            var buttons = BrowserInstance.FindElements(By.XPath("//*//ion-router-outlet/app-list/ion-footer/ion-toolbar/ion-buttons"));
      

            element = buttons[0].FindElement(By.XPath(".//ion-button"));
            element.Click();
            Thread.Sleep(20 * Constants.StandartWaitTime);
            return true;
        }
    }
}

