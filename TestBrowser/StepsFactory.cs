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
                new NavMenuTree(),
                new SelectFilter(),
                new AddNewData(),
                new SetComment(),
                new SetDate(),
                new SaveChanges(),
                new Logout(),
            };
        }
    }
}
