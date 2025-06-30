using OpenQA.Selenium;

namespace TestBrowser.Steps
{
    internal class CreateEmployee : StepBase
    {
        public CreateEmployee() : base("createEmployee")
        {
        }


        public override bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath)
        {
            IWebElement element;

            var dialogContainer = BrowserInstance.FindElement(By.XPath("//*//body/div/div/div/mat-dialog-container"));

            //4 divs
            var felds = dialogContainer.FindElements(By.XPath(".//div/div/app-agregar-editar-persona/form/mat-dialog-content/div"));

            //Name
            element = felds[0].FindElement(By.XPath(".//div/mat-form-field/div/div/div/input"));

            element.Click();
            element.SendKeys("Lucas");

            //Email
            element = felds[1].FindElement(By.XPath(".//div/mat-form-field/div/div/div/input"));

            element.Click();
            element.SendKeys("lucas_frota@hotmail.com");

            //Type Document
            element = felds[1].FindElement(By.XPath(".//div/mat-form-field/div/div/div/input"));

            element.Click();
            element.SendKeys("lucas_frota@hotmail.com");

            Thread.Sleep(20 * Constants.StandartWaitTime);

            return true;
        }
    }
}

