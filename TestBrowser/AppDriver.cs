using OpenQA.Selenium;
using TestBrowser.Models;
using TestBrowser.Steps;

namespace TestBrowser
{
    public class AppDriver 
    {
        private IWebDriver BrowserInstance;
        //protected string? WebUrl {  get; set; }
        private List<StepBase> stepBases;



        public AppDriver(IWebDriver browserInstance, string webUrl)
        {


            this.BrowserInstance = browserInstance;
            //this.WebUrl = webUrl;
            this.stepBases = StepsFactory.Create(webUrl);
        }

        public bool Run(JsonModel stepsData)
        {
            foreach (var item in stepsData.Steps)
            {
                Console.WriteLine($"Step running :{item.Key}");
                //Console.WriteLine($"function name: {item.Value.function_name}, value: {item.Value.step_value}, path: {item.Value.step_menu_name_path}\n");
                bool retValue = BrowserAction(item.Value.function_name, item.Value.step_value, item.Value.step_path);
                if( retValue == false)
                {
                    Console.WriteLine($"Test {item.Key} failed.");
                    return false;
                }
                //Console.WriteLine($"Error on executing the step '{item.Value.function_name}': {item.Value.step_value}");
            }
            return true;
        }

        private bool BrowserAction(string functionName, string stepValue, string menuNamePath)
        {
            if (stepBases.Any(s => s.ComandName == functionName) == false)
            {
                Console.WriteLine("function name does not exist.");
                return false;
            }

            var step = stepBases.Single(s => s.ComandName == functionName);
            //EXTRA DELAY
            Thread.Sleep(30*Constants.StandartWaitTime);
            bool stepResult = step.Step(BrowserInstance, stepValue, menuNamePath);
            return stepResult;
        }
    }
}
