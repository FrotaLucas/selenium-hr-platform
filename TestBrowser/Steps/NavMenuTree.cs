using OpenQA.Selenium;


namespace TestBrowser.Steps
{
    internal class NavMenuTree : StepBase
    {
        public NavMenuTree() : base("navMenuTree")
        {

        }

        public override bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath)
        {
            IWebElement element;
            IWebElement treeViewParent;

            treeViewParent = BrowserInstance.FindElement(By.XPath("//*//ion-router-outlet/app-home/ion-content/span/is-tree-view/span/is-tree-view"));

            var labels = treeViewParent.FindElements(By.XPath(".//ion-label"));

            foreach (var label in labels)
            {
                if (label.Text.Trim() == stepValue)
                {
                    Thread.Sleep(2 * Constants.StandartWaitTime);
                    label.Click();
                    return true;
                }
            }

            return false;
        }
    }
}
