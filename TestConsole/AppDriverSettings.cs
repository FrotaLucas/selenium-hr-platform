using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using TestBrowser;

namespace TestConsole
{
    internal static class AppDriverSettings
    {
       internal static AppDriver GetWebDriver()
        {
            AppDriver appDriver;

            var driverPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (AppSettings.BrowserType == "Chrome")
            {
                //string chromeExeLocation = AppSettings.ChromeExeLocation;
                ChromeDriver browserInstance;

                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                options.SetLoggingPreference(LogType.Browser, LogLevel.All);
                options.SetLoggingPreference(LogType.Driver, LogLevel.All);

                browserInstance = new ChromeDriver(driverPath, options);
                appDriver = new AppDriver(browserInstance, AppSettings.WebUrl);
            }

            else if (AppSettings.BrowserType == "Edge")
            {
                EdgeDriver browserInstance = new EdgeDriver(driverPath);

                appDriver = new AppDriver(browserInstance, AppSettings.WebUrl);
            }

            else { throw new Exception(string.Format("invalid browser type { 0 } use: Chrome or Edge", AppSettings.BrowserType)); }

            return appDriver;
        }
     
    }
}
