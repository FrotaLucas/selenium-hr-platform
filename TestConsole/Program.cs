using System.Data;
using System.Text.Json;
using TestBrowser;
using TestBrowser.Models;
using TestConsole;

Console.WriteLine("start, Project!");


string editorName;
AppDriver webDriver;
var steps = new List<string>();

if ( !OperatingSystem.IsWindows())
{
    throw new Exception("The app is running on windows");
}

editorName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').ToArray().Last();
Console.WriteLine($"EditorName: {editorName}\n{AppSettings.WebUrl}\nBrowser: {AppSettings.BrowserType}\n chrome in silent mode: {AppSettings.ChromeSilent}");

webDriver = AppDriverSettings.GetWebDriver();

//string jsonFilePath = "C:\\MyFolders\\Visual_Studio_Projects\\IHK\\selenium-ihk-project\\TestConsole\\Steps.json";
string jsonFilePath = "C:\\MyFolders\\Visual_Studio_Projects\\selenium-hr-platform\\TestConsole\\Steps.json";

if (!File.Exists(jsonFilePath))
{
    throw new Exception("JSON file not found.");
}

string jsonContent = File.ReadAllText(jsonFilePath);

var stepsData = JsonSerializer.Deserialize<JsonModel>(jsonContent);
if( stepsData.Steps == null ||  stepsData.Steps.Count == 0 )
{   
    throw new Exception("Steps not found.");
}

bool result = webDriver.Run(stepsData);

if(result)
Console.WriteLine("Test successfully finished");








