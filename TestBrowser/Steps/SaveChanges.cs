using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBrowser.Steps
{
    internal class SaveChanges : StepBase
    {
        public SaveChanges() : base("saveChanges")
        {
        }


        //REPLICAR TRY CATCH PARA OS OUTROS CASOS OU TENTAR USAR LISTA E CHECAR SE A LISTA ESTA VAZIA
        public override bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath)
        {
            IWebElement element;

            try {
                var buttons = BrowserInstance.FindElements(By.XPath("//*//ion-router-outlet/app-webform/ion-footer/ion-toolbar/ion-buttons"));


                element = buttons[0].FindElement(By.XPath(".//ion-button"));
                element.Click();
                Thread.Sleep(20 * Constants.StandartWaitTime);
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
