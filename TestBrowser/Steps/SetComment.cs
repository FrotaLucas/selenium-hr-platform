using OpenQA.Selenium;

namespace TestBrowser.Steps
{
    internal class SetComment : StepBase
    {
        public SetComment() : base("setComment")
        {
        }

        public override bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath)
        {
            IWebElement element;
            IWebElement textElement;


            //list of Fields
            var spans = BrowserInstance.FindElements(By.XPath("//*//ion-router-outlet/app-webform/ion-content/span/is-section/div/span"));
            //Console.WriteLine($"total {spans.Count()} ");

            //field Textarea
            element = spans[2].FindElements(By.XPath(".//ion-item")).Last();
            element.Click();
            Thread.Sleep(20 * Constants.StandartWaitTime);

            //modal
            textElement = BrowserInstance.FindElement(By.XPath("//*//ion-app/ion-modal/app-is-textbox-popup/ion-content/ion-textarea/label/div/div/textarea"));

            textElement.Clear();
            textElement.SendKeys(stepValue);

            //save changes
            var listOfTooBars = BrowserInstance.FindElements(By.XPath("//*//ion-app/ion-modal/app-is-textbox-popup/ion-toolbar"));
            //Console.WriteLine($"list of toolbars {listOfTooBars.Count()}");
            element = listOfTooBars[1].FindElement(By.ClassName("popup-footer-right-div"));
            element.Click();

            return true;
        }
    }
}

