namespace TestBrowser.Models
{
    public class JsonModel
    {
        public string Mandant { get; set; } = string.Empty;
        public string Scenario { get; set; } = string.Empty;
        public Dictionary<string, StepModel> Steps { get; set; }
    }
}