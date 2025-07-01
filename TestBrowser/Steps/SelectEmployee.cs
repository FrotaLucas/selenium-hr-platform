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

            var employee = BrowserInstance.FindElement(By.XPath("//*//app-root/app-list-personas/mat-card/table/tbody/tr/td"));
            var deleteButton = employee.FindElements(By.TagName("mat-icon")).Last();
            deleteButton.Click();   

            return true;

        }
    }
   
 
    
}

