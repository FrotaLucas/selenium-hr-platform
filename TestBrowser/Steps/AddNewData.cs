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

            var button = BrowserInstance.FindElement(By.XPath("//*//app-root/app-list-personas/mat-card/div/button"));
    
            button.Click();
            Thread.Sleep(20 * Constants.StandartWaitTime);
            return true;
        }
    }
}

