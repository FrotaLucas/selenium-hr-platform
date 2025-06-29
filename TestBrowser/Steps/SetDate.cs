using OpenQA.Selenium;

namespace TestBrowser.Steps
{
    internal class SetDate : StepBase
    {
        protected IWebDriver BrowserInstance;
        public SetDate() : base("setDate")
        {
        }

        public override bool Step(IWebDriver BrowserInstance, string? stepValue, string? stepPath)
        {
            this.BrowserInstance = BrowserInstance;

            IWebElement? element = null;
            IWebElement modalElement;
            string[] date = stepValue.Split('/');
            int indexDate;
            
            //list of Spans
            var listOfSpans = BrowserInstance.FindElements(By.XPath("//*//ion-router-outlet/app-webform/ion-content/span/is-section/div/span"));
            Console.WriteLine($"total {listOfSpans.Count()} ");

            //field Date

            if (stepPath == "1")
            {
                element = listOfSpans[10].FindElement(By.XPath(".//is-datepicker"));
            }

            if (stepPath == "2")
            {
                element = listOfSpans[11].FindElement(By.XPath(".//is-datepicker"));
            }

            if(element == null)
            {
                return false;
            }
            element.Click();



            //modal
            IWebElement shadowHost = BrowserInstance.FindElement(By.XPath("//*//app-root/ion-app/ion-modal/div/ion-content/ion-datetime"));
            HighlightQuery(shadowHost);
            IJavaScriptExecutor js = (IJavaScriptExecutor)BrowserInstance;
            ShadowRoot shadowRoot = (ShadowRoot)js.ExecuteScript("return arguments[0].shadowRoot", shadowHost);
            IWebElement dateTimeCalendar = shadowRoot.FindElement(By.CssSelector("div.datetime-calendar"));
            dateTimeCalendar = dateTimeCalendar.FindElement(By.CssSelector("div.calendar-body"));
            dateTimeCalendar = dateTimeCalendar.FindElement(By.CssSelector("div.calendar-month"));
            dateTimeCalendar = dateTimeCalendar.FindElement(By.CssSelector("div.calendar-month-grid"));
            Console.WriteLine($"inside {dateTimeCalendar.TagName} ");
            var days = dateTimeCalendar.FindElements(By.CssSelector("div.calendar-day-wrapper"));

            //var singleDiv = BrowserInstance.FindElement(By.XPath("//*//app-root/ion-app/ion-modal/div/ion-content/ion-datetime/div[contains(@class, 'datetime-calendar')]/div[contains(@class, 'calendar-body')]/div[contains(@class, 'calendar-month')]"));
          

            Console.WriteLine("total days" + days.Count );
            foreach (var day in days)
            {
                Console.WriteLine("text day" + day.Text);
                if (day.Text.Contains(date[0]))
                {
                    IWebElement buttonDay = day.FindElement(By.TagName("button"));
                    Console.WriteLine("text day" + buttonDay.Text);
                    Console.WriteLine("tag button" + buttonDay.TagName.ToString());
                    //IWebElement buttonDay = day.FindElement(By.CssSelector("calendar-day")); //not working
                    //IWebElement buttonDay = day.FindElement(By.XPath("//button[contains(@data-day, '" + day.Text +"')]"));
                    buttonDay.Click();
                    break;
                }
            }

            //save changes on modal
            var listButtons = shadowHost.FindElements(By.XPath(".//ion-buttons/ion-button"));
            Console.WriteLine($"total buttons {listButtons.Count()} ");
            listButtons[3].Click();

            return true;
        }

        private void HighlightQuery(IWebElement query)
        {
            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: red"";";
            ((IJavaScriptExecutor)BrowserInstance).ExecuteScript(highlightJavascript, [query]);
        }
    }
}

