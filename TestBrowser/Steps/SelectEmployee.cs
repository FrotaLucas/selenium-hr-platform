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
            Thread.Sleep(20*Constants.StandartWaitTime);

         

            return true;

        }
    }
   
 
    
}

