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
            string[] personalData = stepValue.Split("|");

            var dialogContainer = BrowserInstance.FindElement(By.XPath("//*//body/div/div/div/mat-dialog-container"));

            //4 divs
            var felds = dialogContainer.FindElements(By.XPath(".//div/div/app-agregar-editar-persona/form/mat-dialog-content/div"));

            //Name

            var name = felds[0].FindElement(By.XPath($".//input[contains(@formcontrolname, {personalData[0]})]"));
            name.Click();

            name.SendKeys(personalData[0]);

            //surname 
            var surnameFeld = felds[0].FindElement(By.XPath(".//input[contains(@formcontrolname, 'apellido')]"));
            surnameFeld.Click();

            surnameFeld.SendKeys(personalData[1]);

            //Email
            var email = felds[1].FindElement(By.XPath(".//input[contains(@formcontrolname, 'correo')]"));
            email.Click();

            email.SendKeys(personalData[2]);

            //type of document

            var typeDocumentoFeld = felds[2].FindElement(By.XPath(".//div"));
            typeDocumentoFeld.Click();

            //var matOption = BrowserInstance.FindElement(By.XPath("//*//body/div/div/div/div/mat-option"));
            //var matOption2 = BrowserInstance.FindElement(By.XPath("//*//span[contains(text(), 'DNI')]"));


            var matOption = BrowserInstance.FindElement(By.XPath($"//*//span[contains(text(), {personalData[3]})]"));
            matOption.Click();

            //Document
            var document = felds[2].FindElement(By.XPath(".//input[contains(@formcontrolname, 'documento')]"));
            document.Click();

            //Birthday
            var birthDate = felds[3].FindElement(By.XPath(".//input[contains(@formcontrolname, 'fechaNacimento')]"));
            birthDate.Click();

            birthDate.SendKeys("12/05/1993");

            return true;
        }
    }
}

