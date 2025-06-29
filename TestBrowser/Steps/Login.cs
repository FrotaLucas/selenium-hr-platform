using OpenQA.Selenium;

namespace TestBrowser.Steps
{
    internal class Login : StepBase
    {
      
        public Login() : base("login") 
        {
            
        }

        public override bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath)
        {
            IWebElement element;

            
            //teste unitario  retorna nulo
            //var labels = BrowserInstance.FindElements(By.XPath("//*//ion-router-outlet/app-home/ion-content/div/div/ion-item/ion-label"));
            
            var labels = BrowserInstance.FindElements(By.XPath("//*//ion-router-outlet/app-settings/ion-content/div/div/ion-item/ion-label"));

            if ( labels.Count == 0)
            {
                Console.WriteLine("Elements not found.");
                return false;
            }
            element = labels[0];  

            element.Click();

            return true;
        }
    }
}
