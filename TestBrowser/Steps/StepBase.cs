using OpenQA.Selenium;

namespace TestBrowser.Steps
{

    internal abstract class StepBase
    {
        public string ComandName { get;}
     
        protected StepBase(string stepName)
        {
            ComandName = stepName;
        }

        public abstract bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath);

    }
}

