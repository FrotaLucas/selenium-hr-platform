using OpenQA.Selenium;

namespace TestBrowser.Steps
{
    internal class SelectEmployee : StepBase
    {
        public SelectEmployee() : base("selectEmployee")
        {
            
        }

        public override bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath)
        {
            IWebElement element;


            var filter = BrowserInstance.FindElement(By.XPath("//*//app-root/app-list-personas/mat-card/div/mat-form-field/div/div/div/input"));
            filter.Click();
            filter.SendKeys(stepValue);
            Thread.Sleep(Constants.StandartWaitTime);

            var garbageRow = BrowserInstance.FindElements(By.XPath("//*//app-root/app-list-personas/mat-card/table/tbody/tr/td")).Last();
            var deleteButton = garbageRow.FindElements(By.TagName("mat-icon")).Last();
            deleteButton.Click();   
            Thread.Sleep(Constants.StandartWaitTime);

            return true;

        }
    }
   
 
    
}

