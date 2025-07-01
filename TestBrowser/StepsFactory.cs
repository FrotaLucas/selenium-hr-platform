using TestBrowser.Steps;

namespace TestBrowser
{
    internal class StepsFactory
    {
        public static List<StepBase> Create(string webUrl)
        {
            return new List<StepBase>
            {
                new Login(),
                new NewEnvironment(webUrl),
                new SelectEmployee(),
                new AddNewData(),
                new SetDate(),
                new CreateEmployee(),
            };
        }
    }
}
