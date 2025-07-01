using TestBrowser.Steps;

namespace TestBrowser
{
    internal class StepsFactory
    {
        public static List<StepBase> Create(string webUrl)
        {
            return new List<StepBase>
            {
                new NewEnvironment(webUrl),
                new AddNewData(),
                new CreateEmployee(),
                new SelectEmployee(),
                new DeleteEmployee(),
            };
        }
    }
}
