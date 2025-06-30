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
            var name = felds[0].FindElement(By.XPath(".//input[contains(@formcontrolname, 'nombre')]"));
            name.Click();

            name.SendKeys("Lucas");

            //surname 
            var surnameFeld = felds[0].FindElement(By.XPath(".//input[contains(@formcontrolname, 'apellido')]"));
            surnameFeld.Click();

            surnameFeld.SendKeys("Dias Frota");

            //Email
            var email = felds[1].FindElement(By.XPath(".//input[contains(@formcontrolname, 'correo')]"));
            email.Click();

            email.SendKeys("lucas_frota@hotmail.com");

            //Birthday
            var birthDate = felds[3].FindElement(By.XPath(".//input[contains(@formcontrolname, 'fechaNacimento')]"));
            birthDate.Click();

            birthDate.SendKeys("12/05/1993");

            return true;
        }
    }
}

