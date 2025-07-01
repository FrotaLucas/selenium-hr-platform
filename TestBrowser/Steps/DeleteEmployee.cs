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
            throw new NotImplementedException();
        }
    }
}
