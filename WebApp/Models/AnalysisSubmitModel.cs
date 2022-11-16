namespace WebApp.Models
{
    public class AnalysisSubmitModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public int TotalCommits { get; set; }
        public IList<string> Urls { get; set; }
    }
}
