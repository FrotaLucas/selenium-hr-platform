using OpenQA.Selenium;

namespace TestBrowser.Steps
{
    internal class SelectEmployee : StepBase
    {
        public SelectEmployee() : base("selectFilter")
        {
            
        }

        public override bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath)
        {
            IWebElement element;

            var divs = BrowserInstance.FindElements(By.XPath("//*//ion-router-outlet/app-filter/ion-content/div"));

            //Console.WriteLine(divs.Count());

            foreach (var div in divs)
            {
                if (div.Text == stepValue)
                {
                    element = div.FindElements(By.XPath(".//ion-col")).Last();
                    element = element.FindElement(By.XPath(".//ion-segment-button"));
                    element.Click();
                    
                    return true;
                }

            }

            return false;

        }
    }
   
 
    
}

