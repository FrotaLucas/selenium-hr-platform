using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestBrowser.Steps
{
    internal class DeleteEmployee : StepBase
    {
        public DeleteEmployee() : base("deleteEmployee")
        {
            
        }

        public override bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath)
        {
            var garbageRow = BrowserInstance.FindElements(By.XPath("//*//app-root/app-list-personas/mat-card/table/tbody/tr/td")).Last();
            var deleteButton = garbageRow.FindElements(By.TagName("mat-icon")).Last();
            deleteButton.Click();
            Thread.Sleep(Constants.StandartWaitTime);

            return true;
        }
    }
}
