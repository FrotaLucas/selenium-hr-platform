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

            //dialog-content
            element = dialogContainer.FindElement(By.XPath(".//div/div/app-agregar-editar-persona/form/mat-dialog-content"));

            //Name
            element = element.FindElement(By.XPath(".//div/div/mat-form-field/div/div/div/input"));

            element.Click();

            Thread.Sleep(20 * Constants.StandartWaitTime);



            var SecbackButton = BrowserInstance.FindElements(By.XPath("//*//ion-router-outlet/app-list/ion-header/ion-toolbar/ion-buttons"));
            element = SecbackButton[0].FindElement(By.XPath(".//ion-back-button"));
            element.Click();
            Thread.Sleep(20 * Constants.StandartWaitTime);

            var thirdBackButton = BrowserInstance.FindElements(By.XPath("//*//ion-router-outlet/app-filter/ion-header/ion-toolbar/ion-buttons"));
            element = thirdBackButton[0].FindElement(By.XPath(".//ion-back-button"));
            element.Click();
            Thread.Sleep(20 * Constants.StandartWaitTime);


            var menuButton = BrowserInstance.FindElement(By.XPath("//*//ion-router-outlet/app-home/ion-header/ion-toolbar/ion-buttons/ion-menu-toggle"));
            Thread.Sleep(20 * Constants.StandartWaitTime);
            menuButton.Click();

            var logOut = BrowserInstance.FindElements(By.XPath("//*//app-root/ion-app/ion-menu/ion-content/ion-menu-toggle"));
            Thread.Sleep(30 * Constants.StandartWaitTime);
            logOut[5].Click();

            var confirmBUtton = BrowserInstance.FindElements(By.XPath("//*//ion-app/ion-modal/app-is-user-alert-frage/ion-toolbar/div"));
            Thread.Sleep(30 * Constants.StandartWaitTime);
            element = confirmBUtton[1];
            element.Click(); 
            
            return true;
        }
    }
}

